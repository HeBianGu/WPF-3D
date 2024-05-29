using Kitware.VTK;
using System;
using System.IO;
using System.Reflection;

namespace HeBianGu.Test.VTK
{
    public static class vtkRendererExtension
    {
        public static void RenderVtkAlgorithm(this vtkRenderer vtkRenderer, vtkAlgorithm vtkAlgorithm)
        {
            vtkRenderer.RendervtkAlgorithmOutput(vtkAlgorithm.GetOutputPort());
        }

        public static void RendervtkAlgorithmOutput(this vtkRenderer vtkRenderer, vtkAlgorithmOutput vtkAlgorithmOutput)
        {
            vtkPolyDataMapper mapper = vtkPolyDataMapper.New();
            mapper.SetInputConnection(vtkAlgorithmOutput);
            vtkActor actor = vtkActor.New();
            actor.SetMapper(mapper);
            vtkRenderer.SetBackground(0.2, 0.3, 0.4);
            vtkRenderer.AddActor(actor);
        }


        public static void RendervtkProp(this vtkRenderer vtkRenderer, Func<vtkProp> action)
        {
            vtkRenderer.AddActor(action.Invoke());
        }

        public static void Render(this vtkRenderer vtkRenderer, Action action)
        {
            action.Invoke();
        }

        public static void RenderVtkAlgorithm(this vtkRenderer vtkRenderer, Func<vtkAlgorithm> get)
        {
            var algorithm = get.Invoke();
            if (algorithm == null)
                return;
            vtkRenderer.RenderVtkAlgorithm(algorithm);
        }

        public static vtkOBJReader RenderObj(this vtkRenderer vtkRenderer, string filePath)
        {
            vtkOBJReader reader = vtkOBJReader.New();
            vtkRenderer.RenderVtkAlgorithm(() =>
            {
                reader.SetFileName(filePath);
                reader.Update();
                return reader;
            });
            return reader;
        }

        public static vtkPLYReader RenderPLY(this vtkRenderer vtkRenderer, string filePath)
        {
            vtkPLYReader reader = vtkPLYReader.New();
            vtkRenderer.RenderVtkAlgorithm(() =>
            {
                reader.SetFileName(filePath);
                reader.Update();
                return reader;
            });
            return reader;
        }

        public static T RenderPolyDataReader<T>(this vtkRenderer vtkRenderer, string filePath) where T : vtkAbstractPolyDataReader
        {
            T reader = vtkObjectBaseFactory.New<T>();
            vtkRenderer.RenderVtkAlgorithm(() =>
            {
                reader.SetFileName(filePath);
                reader.Update();
                return reader;
            });
            return reader;
        }

        public static void RenderOBJImporter(this vtkRenderWindow  vtkRenderWindow, string filePath)
        {
            vtkOBJImporter importer = vtkOBJImporter.New();
            importer.SetFileName(filePath);
            var mtl = Path.ChangeExtension(filePath, "mtl");
            if (File.Exists(mtl))
            {
                importer.SetFileNameMTL(mtl);
                importer.SetTexturePath(System.IO.Path.GetDirectoryName(filePath));
            }
            vtkRenderer renderer = vtkRenderWindow.GetRenderers().GetFirstRenderer();
            renderer.SetBackground(0.3, 0.6, 0.3);
            vtkRenderWindow.Render();
            importer.SetRenderWindow(vtkRenderWindow);
            importer.Update();
        }

        public static string ToRootData(this string path)
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            return System.IO.Path.Combine(root, "Data", path);
        }
    }

    public class vtkObjectBaseFactory
    {
        public static T New<T>() where T : vtkObjectBase
        {
            var m = typeof(T).GetMethod("New", BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            if (m == null)
                return null;
            return m.Invoke(null, null) as T;
        }
    }
}