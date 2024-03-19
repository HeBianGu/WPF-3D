using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVRMLImporter
	/// </summary>
	/// <remarks>
	///    imports VRML 2.0 files.
	///
	///
	/// vtkVRMLImporter imports VRML 2.0 files into VTK.
	///
	/// @warning
	/// These nodes are currently supported:
	///      Appearance                              IndexedFaceSet
	///      Box                                     IndexedLineSet
	///      Color                                   Material
	///      Cone                                    Shape
	///      Coordinate                              Sphere
	///      Cylinder                                Transform
	///      DirectionalLight
	///
	/// @warning
	/// As you can see this implementation focuses on getting the geometry
	/// translated.  The routes and scripting nodes are ignored since they deal
	/// with directly accessing a nodes internal structure based on the VRML
	/// spec. Since this is a translation the internal data structures differ
	/// greatly from the VRML spec and the External Authoring Interface (see the
	/// VRML spec). The DEF/USE mechanism does allow the VTK user to extract
	/// objects from the scene and directly manipulate them using the native
	/// language (Python, Java, or whatever language VTK is wrapped
	/// in). This, in a way, removes the need for the route and script mechanism
	/// (not completely though).
	/// Texture coordinates are attached to the mesh is available but
	/// image textures are not loaded.
	/// Viewpoints (camera presets) are not imported.
	///
	/// @par Thanks:
	///  Thanks to Russ Coucher of Areva for numerous bug fixes and a new test.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImporter
	/// </seealso>
	// Token: 0x02000187 RID: 391
	public class vtkVRMLImporter : vtkImporter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004B19 RID: 19225 RVA: 0x0006D50B File Offset: 0x0006B70B
		static vtkVRMLImporter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVRMLImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVRMLImporter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004B1A RID: 19226 RVA: 0x0006D533 File Offset: 0x0006B733
		public vtkVRMLImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004B1B RID: 19227
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B1C RID: 19228 RVA: 0x0006D544 File Offset: 0x0006B744
		public new static vtkVRMLImporter New()
		{
			vtkVRMLImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B1D RID: 19229 RVA: 0x0006D598 File Offset: 0x0006B798
		public vtkVRMLImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVRMLImporter.vtkVRMLImporter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004B1E RID: 19230 RVA: 0x0006D5DC File Offset: 0x0006B7DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004B1F RID: 19231
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLImporter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B20 RID: 19232 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkVRMLImporter.vtkVRMLImporter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004B21 RID: 19233
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMLImporter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B22 RID: 19234 RVA: 0x0006D624 File Offset: 0x0006B824
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06004B23 RID: 19235
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVRMLImporter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B24 RID: 19236 RVA: 0x0006D644 File Offset: 0x0006B844
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06004B25 RID: 19237
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkVRMLImporter_GetOutputsDescription_04(HandleRef pThis);

		/// <summary>
		/// Get a printable string describing the outputs
		/// </summary>
		// Token: 0x06004B26 RID: 19238 RVA: 0x0006D660 File Offset: 0x0006B860
		public override string GetOutputsDescription()
		{
			return vtkVRMLImporter.vtkVRMLImporter_GetOutputsDescription_04(base.GetCppThis());
		}

		// Token: 0x06004B27 RID: 19239
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMLImporter_GetShapeResolution_05(HandleRef pThis);

		/// <summary>
		/// Specify the resolution for Sphere, Cone and Cylinder shape sources.
		/// Default is 12.
		/// </summary>
		// Token: 0x06004B28 RID: 19240 RVA: 0x0006D680 File Offset: 0x0006B880
		public virtual int GetShapeResolution()
		{
			return vtkVRMLImporter.vtkVRMLImporter_GetShapeResolution_05(base.GetCppThis());
		}

		// Token: 0x06004B29 RID: 19241
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLImporter_GetVRMLDEFObject_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// In the VRML spec you can DEF and USE nodes (name them),
		/// This routine will return the associated VTK object which
		/// was created as a result of the DEF mechanism
		/// Send in the name from the VRML file, get the VTK object.
		/// You will have to check and correctly cast the object since
		/// this only returns vtkObjects.
		/// </summary>
		// Token: 0x06004B2A RID: 19242 RVA: 0x0006D6A0 File Offset: 0x0006B8A0
		public vtkObject GetVRMLDEFObject(string name)
		{
			vtkObject vtkObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_GetVRMLDEFObject_06(base.GetCppThis(), name, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObject = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObject.Register(null);
				}
			}
			return vtkObject;
		}

		// Token: 0x06004B2B RID: 19243
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMLImporter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B2C RID: 19244 RVA: 0x0006D710 File Offset: 0x0006B910
		public override int IsA(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06004B2D RID: 19245
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVRMLImporter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B2E RID: 19246 RVA: 0x0006D730 File Offset: 0x0006B930
		public new static int IsTypeOf(string type)
		{
			return vtkVRMLImporter.vtkVRMLImporter_IsTypeOf_08(type);
		}

		// Token: 0x06004B2F RID: 19247
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLImporter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B30 RID: 19248 RVA: 0x0006D74C File Offset: 0x0006B94C
		public new vtkVRMLImporter NewInstance()
		{
			vtkVRMLImporter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004B31 RID: 19249
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVRMLImporter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004B32 RID: 19250 RVA: 0x0006D7A8 File Offset: 0x0006B9A8
		public new static vtkVRMLImporter SafeDownCast(vtkObjectBase o)
		{
			vtkVRMLImporter vtkVRMLImporter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVRMLImporter.vtkVRMLImporter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVRMLImporter = (vtkVRMLImporter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVRMLImporter.Register(null);
				}
			}
			return vtkVRMLImporter;
		}

		// Token: 0x06004B33 RID: 19251
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMLImporter_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the name of the file to read.
		/// </summary>
		// Token: 0x06004B34 RID: 19252 RVA: 0x0006D827 File Offset: 0x0006BA27
		public virtual void SetFileName(string _arg)
		{
			vtkVRMLImporter.vtkVRMLImporter_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06004B35 RID: 19253
		[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVRMLImporter_SetShapeResolution_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the resolution for Sphere, Cone and Cylinder shape sources.
		/// Default is 12.
		/// </summary>
		// Token: 0x06004B36 RID: 19254 RVA: 0x0006D837 File Offset: 0x0006BA37
		public virtual void SetShapeResolution(int _arg)
		{
			vtkVRMLImporter.vtkVRMLImporter_SetShapeResolution_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400075F RID: 1887
		public new const string MRFullTypeName = "Kitware.VTK.vtkVRMLImporter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000760 RID: 1888
		public new static readonly string MRClassNameKey = "class vtkVRMLImporter";
	}
}
