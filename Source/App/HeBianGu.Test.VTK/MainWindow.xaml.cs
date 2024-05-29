using Kitware.VTK;
using System;
using System.IO;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeBianGu.Test.VTK
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
        private void w_Loaded(object sender, RoutedEventArgs e)
        {
            vtkRenderer renderer = this.w.RenderWindow.GetRenderers().GetFirstRenderer();
            //renderer.RenderPolyDataReader<vtkOBJReader>(this.GetRootData("Boy\\boy.obj"));
            //renderer.RenderPolyDataReader<vtkDEMReader>(this.GetRootData("Boy\\boy.obj"));

            //this.ReadFix(ren1, renWin);
            //this.ReadStl(ren1, renWin);
            //this.ReadPLY(ren1, renWin);
            //this.OBJImporter(ren1, renWin);


            //renderer.RendervtkProp(() =>
            //{
            //    string filePath = this.GetRootData(@"SainteHelens.dem");
            //    vtkDEMReader reader = vtkDEMReader.New();
            //    reader.SetFileName(filePath);
            //    reader.Update();

            //    vtkLookupTable lut = vtkLookupTable.New();
            //    lut.SetHueRange(0.6, 0);
            //    lut.SetSaturationRange(1.0, 0);
            //    lut.SetValueRange(0.5, 1.0);
            //    double[] range = reader.GetOutput().GetScalarRange();
            //    lut.SetTableRange(range[0], range[1]);

            //    // Visualize
            //    vtkImageMapToColors mapColors = vtkImageMapToColors.New();
            //    mapColors.SetLookupTable(lut);
            //    mapColors.SetInputConnection(reader.GetOutputPort());

            //    // Create an actor
            //    vtkImageActor actor = vtkImageActor.New();
            //    actor.SetInputData(mapColors.GetOutput());

            //    return actor;
            //});

            //renderer.Render(() =>
            //{
            //    vtkJPEGReader reader = vtkJPEGReader.New();
            //    reader.SetFileName(this.GetRootData(@"Gourds2.jpg"));
            //    reader.Update();
            //    vtkImageViewer2 imageViewer = vtkImageViewer2.New();
            //    imageViewer.SetInputConnection(reader.GetOutputPort());
            //    renderer.SetBackground(0.2, 0.3, 0.4);
            //    imageViewer.SetRenderer(renderer);
            //});

            //this.w.RenderWindow.Render();

            //this.ReadJPEG(this.GetRootData("Gourds2.jpg"));

            //this.ReadPNG(this.GetRootData("Gourds.png"));
            //this.w.RenderWindow.Render();

            this.w.RenderWindow.RenderOBJImporter(@"Boy\boy.obj".ToRootData());
        }


        public vtkRenderer GetVtkRenderer()
        {
            return this.w.RenderWindow.GetRenderers().GetFirstRenderer();
        }


        private void ReadPNG(string filePath)
        {
            vtkPNGReader reader = vtkPNGReader.New();
            reader.SetFileName("D:\\GitHub\\WPF-3D\\Source\\App\\HeBianGu.Test.VTK\\bin\\x64\\Debug\\net7.0-windows\\Data\\fran_cut.png");
            reader.Update();
            // Visualize
            //vtkImageViewer2 imageViewer = vtkImageViewer2.New();
            //imageViewer.SetInputConnection(reader.GetOutputPort());
            //imageViewer.SetupInteractor(this.w.Interactor);                              
            //imageViewer.Render();
            //imageViewer.SetRenderWindow(this.w.RenderWindow);
            //this.w.Interactor.Start();
            // get a reference to the renderwindow of our renderWindowControl1
            //// renderer
            //vtkRenderer renderer =this.GetVtkRenderer();
            //// set background color
            //renderer.SetBackground(0.2, 0.3, 0.4);
            ////imageViewer.SetRenderer(renderer);
            //imageViewer.SetRenderWindow(this.w.RenderWindow);

            //vtkImageMapper3D vtkImageMapper = (vtkImageMapper3D)vtkImageMapper3D.New();
            //vtkImageMapper.SetInputConnection(reader.GetOutputPort());
            vtkImageActor vtkImageActor = vtkImageActor.New();
            vtkImageActor.SetInputData(reader.GetImageDataInput(0));
            var render = this.GetVtkRenderer();
            render.AddActor(vtkImageActor);

        }

        private void ReadJPEG(string filePath)
        {
            // Path to vtk data must be set as an envir
            vtkJPEGReader reader = vtkJPEGReader.New();
            reader.SetFileName(filePath);
            reader.Update();

            // Visualize
            vtkImageViewer2 imageViewer = vtkImageViewer2.New();
            imageViewer.SetInputConnection(reader.GetOutputPort());
            // get a reference to the renderwindow of our renderWindowControl1
            // renderer
            vtkRenderer renderer = this.GetVtkRenderer();
            // set background color
            renderer.SetBackground(0.2, 0.3, 0.4);
            imageViewer.SetRenderer(renderer);
        }

        public string GetRootData(string path)
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            return System.IO.Path.Combine(root, "Data", path);
        }


        public void Method()
        {
            // Create a simple sphere. A pipeline is created.
            vtkSphereSource sphere = vtkSphereSource.New();
            sphere.SetThetaResolution(8);
            sphere.SetPhiResolution(16);

            vtkShrinkPolyData shrink = vtkShrinkPolyData.New();
            shrink.SetInputConnection(sphere.GetOutputPort());
            shrink.SetShrinkFactor(0.9);

            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(shrink.GetOutputPort());

            // The actor links the data pipeline to the rendering subsystem
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            actor.GetProperty().SetColor(1, 0, 0);

            // Create components of the rendering subsystem
            //
            vtkRenderer ren1 = w.RenderWindow.GetRenderers().GetFirstRenderer();
            vtkRenderWindow renWin = w.RenderWindow;

            // Add the actors to the renderer, set the window size
            //
            ren1.AddViewProp(actor);
            //renWin.SetSize(250, 250);
            renWin.Render();
            vtkCamera camera = ren1.GetActiveCamera();
            camera.Zoom(1.5);
        }


        public void OBJImporter(vtkRenderer ren1, vtkRenderWindow renWin)
        {
            string filePath = @"H:\Github\vtk-examples-master\src\Testing\Data\Boy\boy.obj";
            //filePath = "H:\\Github\\vtk-examples-master\\src\\Testing\\Data\\doorman\\doorman.obj";
            vtkOBJImporter importer = vtkOBJImporter.New();
            importer.SetFileName(filePath);
            importer.SetFileNameMTL(@"H:\Github\vtk-examples-master\src\Testing\Data\Boy\boy.mtl");
            //importer.SetFileNameMTL(@"H:\Github\vtk-examples-master\src\Testing\Data\doorman\doorman.mtl");
            importer.SetTexturePath(System.IO.Path.GetDirectoryName(filePath));
            // get a reference to the renderwindow of our renderWindowControl1
            vtkRenderWindow renderWindow = renWin;
            // renderer
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            // set background color
            renderer.SetBackground(0.3, 0.6, 0.3);
            // add our actor to the renderer
            //renderer.AddActor(actor);
            renderWindow.Render();
            importer.SetRenderWindow(renWin);
            importer.Update();
        }


        private void ReadOBJ(vtkRenderer ren1, vtkRenderWindow renWin)
        {
            // Path to vtk data must be set as an environment variable
            // VTK_DATA_ROOT = "C:\VTK\vtkdata-5.8.0"
            var test = vtkTestingObjectFactory.New();
            //string root = test.GetDataRoot();
            // caution: vtkdata-5.8.0\Data\mni-surface-mesh.obj is no valid obj file!
            //string filePath = System.IO.Path.Combine(root, @"Data\mni-surface-mesh.obj");
            string filePath = @"E:\3D\41-bed_room_fbx_obj\bed_room.obj";
            filePath = @"E:\3D\models\OBJ\WusonOBJ.obj";
            filePath = @"E:\3D\57-couch-obj\couch.obj";
            filePath = "E:\\3D\\helix\\Models\\obj\\tour.obj";
            filePath = "E:\\3D\\helix\\Models\\obj\\wall12.obj";
            vtkOBJReader reader = vtkOBJReader.New();
            reader.SetFileName(filePath);
            reader.Update();
        }


        private void ReadStl(vtkRenderer ren1, vtkRenderWindow renWin)
        {
            // Path to vtk data must be set as an environment variable
            // VTK_DATA_ROOT = "C:\VTK\vtkdata-5.8.0"
            var test = vtkTestingObjectFactory.New();
            //string root = test.GetDataRoot();
            // caution: vtkdata-5.8.0\Data\mni-surface-mesh.obj is no valid obj file!
            //string filePath = System.IO.Path.Combine(root, @"Data\mni-surface-mesh.obj");
            string filePath = @"E:\3D\41-bed_room_fbx_obj\bed_room.obj";
            filePath = @"E:\3D\models\OBJ\WusonOBJ.obj";
            filePath = @"E:\3D\57-couch-obj\couch.obj";
            filePath = "E:\\3D\\helix\\Models\\obj\\tour.obj";
            filePath = "E:\\3D\\models\\STL\\Spider_ascii.stl";
            vtkSTLReader reader = vtkSTLReader.New();
            reader.SetFileName(filePath);
            reader.Update();
            // Visualize
            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(reader.GetOutputPort());
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            // get a reference to the renderwindow of our renderWindowControl1
            vtkRenderWindow renderWindow = renWin;
            // renderer
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            // set background color
            renderer.SetBackground(0.3, 0.6, 0.3);
            // add our actor to the renderer
            renderer.AddActor(actor);
            renderWindow.Render();
        }


        private void ReadPLY(vtkRenderer ren1, vtkRenderWindow renWin)
        {
            // Path to vtk data must be set as an environment variable
            // VTK_DATA_ROOT = "C:\VTK\vtkdata-5.8.0"
            var test = vtkTestingObjectFactory.New();
            //string root = test.GetDataRoot();
            string filePath = "E:\\3D\\models\\PLY\\Wuson.ply";
            vtkPLYReader reader = vtkPLYReader.New();
            reader.SetFileName(filePath);
            reader.Update();
            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(reader.GetOutputPort());

            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            // get a reference to the renderwindow of our renderWindowControl1
            vtkRenderWindow renderWindow = renWin;
            // renderer
            vtkRenderer renderer = renderWindow.GetRenderers().GetFirstRenderer();
            // set background color
            renderer.SetBackground(0.2, 0.3, 0.4);
            // add our actor to the renderer
            renderer.AddActor(actor);
            renderWindow.Render();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Yaw_Button_Click(object sender, RoutedEventArgs e)
        {
            var camera = this.GetVtkRenderer().GetActiveCamera();
            camera.Yaw(30);
            this.w.RenderWindow.Render();
            var wc = camera.GetWindowCenter();
        }

        private void Roll_Button_Click(object sender, RoutedEventArgs e)
        {
            var render = this.GetVtkRenderer();
            var camera = this.GetVtkRenderer().GetActiveCamera();
            //camera.Roll(30);
            //double r= camera.GetRoll();
            //this.GetVtkRenderer().Render();
            //this.w.RenderWindow.Render();
            var wc = camera.GetWindowCenter();
            //camera.SetWindowCenter(0, 0);
            //camera.SetLeftEye(50);

            //camera.Render(render);

            var matrix = camera.GetViewTransformMatrix();
            var transfrom = camera.GetViewTransformObject();
            transfrom.RotateZ(3);

            //camera.Zoom(30);
            this.w.RenderWindow.Render();
        }
    }

    public class BoxWidgetClass
    {
        /// <summary>
        /// A console application that creates a 
        /// vtkRenderWindow without a Windows Form
        /// </summary>
        /// <param name="argv"></param>
        //public static void Main(vtkRenderer ren1, vtkRenderWindow renWin)
        //{
        //    // Demonstrate how to use the vtkBoxWidget 3D widget,
        //    // This script uses a 3D box widget to define a "clipping box" to clip some
        //    // simple geometry (a mace). Make sure that you hit the "W" key to activate the widget.
        //    // Create a mace out of filters.
        //    sphere = vtkSphereSource.New();
        //    cone = vtkConeSource.New();
        //    glyph = vtkGlyph3D.New();

        //    glyph.SetInputConnection(sphere.GetOutputPort());
        //    glyph.SetSource(cone.GetOutput());
        //    glyph.SetVectorModeToUseNormal();
        //    glyph.SetScaleModeToScaleByVector();
        //    glyph.SetScaleFactor(0.25);

        //    // The sphere and spikes are appended into a single polydata. This just makes things
        //    // simpler to manage.
        //    apd = vtkAppendPolyData.New();
        //    apd.AddInput(glyph.GetOutput());
        //    apd.AddInput(sphere.GetOutput());

        //    maceMapper = vtkPolyDataMapper.New();
        //    maceMapper.SetInputConnection(apd.GetOutputPort());

        //    maceActor = vtkLODActor.New();
        //    maceActor.SetMapper(maceMapper);
        //    maceActor.VisibilityOn();

        //    // This portion of the code clips the mace with the vtkPlanes implicit function.
        //    // The clipped region is colored green.
        //    planes = vtkPlanes.New();
        //    clipper = vtkClipPolyData.New();

        //    clipper.SetInputConnection(apd.GetOutputPort());
        //    clipper.SetClipFunction(planes);
        //    clipper.InsideOutOn();

        //    selectMapper = vtkPolyDataMapper.New();
        //    selectMapper.SetInputConnection(clipper.GetOutputPort());

        //    selectActor = vtkLODActor.New();
        //    selectActor.SetMapper(selectMapper);
        //    selectActor.GetProperty().SetColor(0, 1, 0);
        //    selectActor.VisibilityOff();
        //    selectActor.SetScale(1.01, 1.01, 1.01);

        //    // Create the RenderWindow, Renderer and both Actors
        //    //ren1 = vtkRenderer.New();
        //    //renWin = vtkRenderWindow.New();
        //    renWin.AddRenderer(ren1);
        //    iren = vtkRenderWindowInteractor.New();
        //    iren.SetRenderWindow(renWin);

        //    // The SetInteractor method is how 3D widgets are associated with the render
        //    // window interactor. Internally, SetInteractor sets up a bunch of callbacks
        //    // using the Command/Observer mechanism (AddObserver()).
        //    boxWidget = vtkBoxWidget.New();
        //    boxWidget.SetInteractor(iren);
        //    boxWidget.SetPlaceFactor(1.25);
        //    ren1.AddActor(maceActor);
        //    ren1.AddActor(selectActor);

        //    // Add the actors to the renderer, set the background and size
        //    ren1.SetBackground(0.1, 0.2, 0.4);
        //    renWin.SetSize(300, 300);

        //    // Place the interactor initially. The input to a 3D widget is used to 
        //    // initially position and scale the widget. The EndInteractionEvent is
        //    // observed which invokes the SelectPolygons callback.
        //    boxWidget.SetInput(glyph.GetOutput());
        //    boxWidget.PlaceWidget();
        //    boxWidget.EndInteractionEvt += new vtkObject.vtkObjectEventHandler(SelectPolygons);

        //    // render the image
        //    iren.Initialize();
        //    iren.Start();
        //    //Clean up
        //    deleteAllVTKObjects();
        //}

        static vtkSphereSource sphere;
        static vtkConeSource cone;
        static vtkGlyph3D glyph;
        static vtkAppendPolyData apd;
        static vtkPolyDataMapper maceMapper;
        static vtkLODActor maceActor;
        static vtkPlanes planes;
        static vtkClipPolyData clipper;
        static vtkPolyDataMapper selectMapper;
        static vtkLODActor selectActor;
        static vtkRenderer ren1;
        static vtkRenderWindow renWin;
        static vtkRenderWindowInteractor iren;
        static vtkBoxWidget boxWidget;

        /// <summary>
        /// Callback function for boxWidget.EndInteractionEvt
        /// </summary>
        public static void SelectPolygons(vtkObject sender, vtkObjectEventArgs e)
        {
            boxWidget.GetPlanes(planes);
            selectActor.VisibilityOn();
        }

        ///<summary>
        ///Deletes all static objects created
        ///</summary>
        public static void deleteAllVTKObjects()
        {
            //clean up vtk objects
            if (sphere != null) { sphere.Dispose(); }
            if (cone != null) { cone.Dispose(); }
            if (glyph != null) { glyph.Dispose(); }
            if (apd != null) { apd.Dispose(); }
            if (maceMapper != null) { maceMapper.Dispose(); }
            if (maceActor != null) { maceActor.Dispose(); }
            if (planes != null) { planes.Dispose(); }
            if (clipper != null) { clipper.Dispose(); }
            if (selectMapper != null) { selectMapper.Dispose(); }
            if (selectActor != null) { selectActor.Dispose(); }
            if (ren1 != null) { ren1.Dispose(); }
            if (renWin != null) { renWin.Dispose(); }
            if (iren != null) { iren.Dispose(); }
            if (boxWidget != null) { boxWidget.Dispose(); }
        }
    }
}