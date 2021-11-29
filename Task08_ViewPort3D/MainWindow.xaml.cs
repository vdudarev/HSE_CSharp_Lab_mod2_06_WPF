using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ForAssistantWpfApp3DTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button was clicked.");
            // Можно использовать метод FindName, чтобы найти определенный в XAML объект по его параметру x:Name.
            // Например, чтобы найти "groupOfAllModels".
            
            // Для создания нового куба можно не заморачиваться и склонировать уже существующий "standardCube".
            // У него, скорее всего, придется поменять некоторые параметры.
        }


        // Для перемещения объектов.
        private void MoveModel()
        {
            // Для перемещения объекта можно не менять все его вершины, а поменять свойство Transform.
            // Пример:
            double offsetX = (standardCube.Transform as TranslateTransform3D)?.OffsetX ?? 0;
            offsetX += 0.5;
            standardCube.Transform = new TranslateTransform3D(offsetX, 0, 0);
        }


        // Слайдеры:
        // Пример слайдера можно увидеть здесь: https://metanit.com/sharp/wpf/18.2.php
        // И вообще Metanit - хороший сайт.



        // Далее идут вспомогательные методы для выбирания объекта щелчком мыши.
        // Эти методы целиком скопированы из https://docs.microsoft.com/ru-ru/dotnet/desktop/wpf/graphics-multimedia/how-to-hit-test-in-a-viewport3d?view=netframeworkdesktop-4.8
        // Вам нужно вызвать их в правильный момент.

        public void HitTest(object sender, System.Windows.Input.MouseButtonEventArgs args)
        {
            Point mouseposition = args.GetPosition(viewport3D);
            Point3D testpoint3D = new Point3D(mouseposition.X, mouseposition.Y, 0);
            Vector3D testdirection = new Vector3D(mouseposition.X, mouseposition.Y, 10);
            PointHitTestParameters pointparams = new PointHitTestParameters(mouseposition);
            RayHitTestParameters rayparams = new RayHitTestParameters(testpoint3D, testdirection);

            //test for a result in the Viewport3D
            VisualTreeHelper.HitTest(viewport3D, null, HTResult, pointparams);
        }

        public HitTestResultBehavior HTResult(System.Windows.Media.HitTestResult rawresult)
        {
            //MessageBox.Show(rawresult.ToString());
            RayHitTestResult rayResult = rawresult as RayHitTestResult;

            if (rayResult != null)
            {
                RayMeshGeometry3DHitTestResult rayMeshResult = rayResult as RayMeshGeometry3DHitTestResult;

                if (rayMeshResult != null)
                {
                    GeometryModel3D hitgeo = rayMeshResult.ModelHit as GeometryModel3D;

                    //UpdateResultInfo(rayMeshResult);
                    //UpdateMaterial(hitgeo, (side1GeometryModel3D.Material as MaterialGroup));
                    // Единственное изменение:
                    // После того, как вы совершили нужные дествия с hitgeo, нужно вернуть HitTestResultBehavior.Stop.
                    // Иначе HitTest дальше продолжит свою работу.
                }
            }

            return HitTestResultBehavior.Continue;
        }
    }
}
