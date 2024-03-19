using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExporter
	/// </summary>
	/// <remarks>
	///    abstract class to write a scene to a file
	///
	/// vtkExporter is an abstract class that exports a scene to a file. It
	/// is very similar to vtkWriter except that a writer only writes out
	/// the geometric and topological data for an object, where an exporter
	/// can write out material properties, lighting, camera parameters etc.
	/// The concrete subclasses of this class may not write out all of this
	/// information. For example vtkOBJExporter writes out Wavefront obj files
	/// which do not include support for camera parameters.
	///
	/// vtkExporter provides the convenience methods StartWrite() and EndWrite().
	/// These methods are executed before and after execution of the Write()
	/// method. You can also specify arguments to these methods.
	/// This class defines SetInput and GetInput methods which take or return
	/// a vtkRenderWindow.
	/// @warning
	/// Every subclass of vtkExporter must implement a WriteData() method.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOBJExporter vtkRenderWindow vtkWriter
	/// </seealso>
	// Token: 0x020001AB RID: 427
	public abstract class vtkExporter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060052B6 RID: 21174 RVA: 0x000788F3 File Offset: 0x00076AF3
		static vtkExporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060052B7 RID: 21175 RVA: 0x0007891B File Offset: 0x00076B1B
		public vtkExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060052B8 RID: 21176 RVA: 0x00078929 File Offset: 0x00076B29
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060052B9 RID: 21177
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExporter_GetActiveRenderer_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the renderer that contains actors to be written.
		/// If it is set to nullptr (by default), then in most subclasses
		/// the behavior is to only export actors of the first renderer.
		/// In some subclasses, if ActiveRenderer is nullptr then
		/// actors of all renderers will be exported.
		/// The renderer must be in the renderer collection of the specified
		/// RenderWindow.
		/// \sa SetRenderWindow()
		/// </summary>
		// Token: 0x060052BA RID: 21178 RVA: 0x00078934 File Offset: 0x00076B34
		public virtual vtkRenderer GetActiveRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExporter.vtkExporter_GetActiveRenderer_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		// Token: 0x060052BB RID: 21179
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExporter_GetInput_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These methods are provided for backward compatibility. Will disappear
		/// soon.
		/// </summary>
		// Token: 0x060052BC RID: 21180 RVA: 0x000789A4 File Offset: 0x00076BA4
		public vtkRenderWindow GetInput()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExporter.vtkExporter_GetInput_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x060052BD RID: 21181
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExporter_GetMTime_03(HandleRef pThis);

		/// <summary>
		/// Returns the MTime also considering the RenderWindow.
		/// </summary>
		// Token: 0x060052BE RID: 21182 RVA: 0x00078A14 File Offset: 0x00076C14
		public override ulong GetMTime()
		{
			return vtkExporter.vtkExporter_GetMTime_03(base.GetCppThis());
		}

		// Token: 0x060052BF RID: 21183
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExporter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052C0 RID: 21184 RVA: 0x00078A34 File Offset: 0x00076C34
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExporter.vtkExporter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060052C1 RID: 21185
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExporter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052C2 RID: 21186 RVA: 0x00078A54 File Offset: 0x00076C54
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExporter.vtkExporter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060052C3 RID: 21187
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExporter_GetRenderWindow_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the rendering window that contains the scene to be written.
		/// </summary>
		// Token: 0x060052C4 RID: 21188 RVA: 0x00078A70 File Offset: 0x00076C70
		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExporter.vtkExporter_GetRenderWindow_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		// Token: 0x060052C5 RID: 21189
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExporter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052C6 RID: 21190 RVA: 0x00078AE0 File Offset: 0x00076CE0
		public override int IsA(string type)
		{
			return vtkExporter.vtkExporter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060052C7 RID: 21191
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExporter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052C8 RID: 21192 RVA: 0x00078B00 File Offset: 0x00076D00
		public new static int IsTypeOf(string type)
		{
			return vtkExporter.vtkExporter_IsTypeOf_08(type);
		}

		// Token: 0x060052C9 RID: 21193
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExporter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052CA RID: 21194 RVA: 0x00078B1C File Offset: 0x00076D1C
		public new vtkExporter NewInstance()
		{
			vtkExporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExporter.vtkExporter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060052CB RID: 21195
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExporter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060052CC RID: 21196 RVA: 0x00078B78 File Offset: 0x00076D78
		public new static vtkExporter SafeDownCast(vtkObjectBase o)
		{
			vtkExporter vtkExporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExporter.vtkExporter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExporter = (vtkExporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExporter.Register(null);
				}
			}
			return vtkExporter;
		}

		// Token: 0x060052CD RID: 21197
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExporter_SetActiveRenderer_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the renderer that contains actors to be written.
		/// If it is set to nullptr (by default), then in most subclasses
		/// the behavior is to only export actors of the first renderer.
		/// In some subclasses, if ActiveRenderer is nullptr then
		/// actors of all renderers will be exported.
		/// The renderer must be in the renderer collection of the specified
		/// RenderWindow.
		/// \sa SetRenderWindow()
		/// </summary>
		// Token: 0x060052CE RID: 21198 RVA: 0x00078BF8 File Offset: 0x00076DF8
		public virtual void SetActiveRenderer(vtkRenderer arg0)
		{
			vtkExporter.vtkExporter_SetActiveRenderer_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060052CF RID: 21199
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExporter_SetInput_12(HandleRef pThis, HandleRef renWin);

		/// <summary>
		/// These methods are provided for backward compatibility. Will disappear
		/// soon.
		/// </summary>
		// Token: 0x060052D0 RID: 21200 RVA: 0x00078C28 File Offset: 0x00076E28
		public void SetInput(vtkRenderWindow renWin)
		{
			vtkExporter.vtkExporter_SetInput_12(base.GetCppThis(), (renWin == null) ? default(HandleRef) : renWin.GetCppThis());
		}

		// Token: 0x060052D1 RID: 21201
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExporter_SetRenderWindow_13(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the rendering window that contains the scene to be written.
		/// </summary>
		// Token: 0x060052D2 RID: 21202 RVA: 0x00078C58 File Offset: 0x00076E58
		public virtual void SetRenderWindow(vtkRenderWindow arg0)
		{
			vtkExporter.vtkExporter_SetRenderWindow_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060052D3 RID: 21203
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExporter_Update_14(HandleRef pThis);

		/// <summary>
		/// Convenient alias for Write() method.
		/// </summary>
		// Token: 0x060052D4 RID: 21204 RVA: 0x00078C87 File Offset: 0x00076E87
		public void Update()
		{
			vtkExporter.vtkExporter_Update_14(base.GetCppThis());
		}

		// Token: 0x060052D5 RID: 21205
		[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExporter_Write_15(HandleRef pThis);

		/// <summary>
		/// Write data to output. Method executes subclasses WriteData() method, as
		/// well as StartWrite() and EndWrite() methods.
		/// </summary>
		// Token: 0x060052D6 RID: 21206 RVA: 0x00078C96 File Offset: 0x00076E96
		public virtual void Write()
		{
			vtkExporter.vtkExporter_Write_15(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007BB RID: 1979
		public new const string MRFullTypeName = "Kitware.VTK.vtkExporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007BC RID: 1980
		public new static readonly string MRClassNameKey = "class vtkExporter";
	}
}
