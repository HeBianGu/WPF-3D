using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGraphicsFactory
	///
	/// </summary>
	// Token: 0x020007E5 RID: 2021
	public class vtkGraphicsFactory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014C3E RID: 85054 RVA: 0x001D62A3 File Offset: 0x001D44A3
		static vtkGraphicsFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphicsFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphicsFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014C3F RID: 85055 RVA: 0x001D62CB File Offset: 0x001D44CB
		public vtkGraphicsFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014C40 RID: 85056
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphicsFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C41 RID: 85057 RVA: 0x001D62DC File Offset: 0x001D44DC
		public new static vtkGraphicsFactory New()
		{
			vtkGraphicsFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C42 RID: 85058 RVA: 0x001D6330 File Offset: 0x001D4530
		public vtkGraphicsFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGraphicsFactory.vtkGraphicsFactory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014C43 RID: 85059 RVA: 0x001D6374 File Offset: 0x001D4574
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014C44 RID: 85060
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphicsFactory_CreateInstance_01([MarshalAs(UnmanagedType.LPUTF8Str)] string vtkclassname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create and return an instance of the named vtk object.
		/// This method first checks the vtkObjectFactory to support
		/// dynamic loading.
		/// </summary>
		// Token: 0x06014C45 RID: 85061 RVA: 0x001D6380 File Offset: 0x001D4580
		public static vtkObject CreateInstance(string vtkclassname)
		{
			vtkObject result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_CreateInstance_01(vtkclassname, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014C46 RID: 85062
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphicsFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C47 RID: 85063 RVA: 0x001D63D8 File Offset: 0x001D45D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014C48 RID: 85064
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGraphicsFactory_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C49 RID: 85065 RVA: 0x001D63F8 File Offset: 0x001D45F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06014C4A RID: 85066
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphicsFactory_GetOffScreenOnlyMode_04();

		/// <summary>
		/// This option enables the off-screen only mode. In this mode no X calls will
		/// be made even when interactor is used.
		/// </summary>
		// Token: 0x06014C4B RID: 85067 RVA: 0x001D6414 File Offset: 0x001D4614
		public static int GetOffScreenOnlyMode()
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetOffScreenOnlyMode_04();
		}

		// Token: 0x06014C4C RID: 85068
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphicsFactory_GetRenderLibrary_05();

		/// <summary>
		/// What rendering library has the user requested
		/// </summary>
		// Token: 0x06014C4D RID: 85069 RVA: 0x001D6430 File Offset: 0x001D4630
		public static string GetRenderLibrary()
		{
			string s = Marshal.PtrToStringAnsi(vtkGraphicsFactory.vtkGraphicsFactory_GetRenderLibrary_05());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06014C4E RID: 85070
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphicsFactory_GetUseMesaClasses_06();

		/// <summary>
		/// This option enables the creation of Mesa classes
		/// instead of the OpenGL classes when using mangled Mesa.
		/// </summary>
		// Token: 0x06014C4F RID: 85071 RVA: 0x001D6464 File Offset: 0x001D4664
		public static int GetUseMesaClasses()
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetUseMesaClasses_06();
		}

		// Token: 0x06014C50 RID: 85072
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphicsFactory_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C51 RID: 85073 RVA: 0x001D6480 File Offset: 0x001D4680
		public override int IsA(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06014C52 RID: 85074
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGraphicsFactory_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C53 RID: 85075 RVA: 0x001D64A0 File Offset: 0x001D46A0
		public new static int IsTypeOf(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_IsTypeOf_08(type);
		}

		// Token: 0x06014C54 RID: 85076
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphicsFactory_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C55 RID: 85077 RVA: 0x001D64BC File Offset: 0x001D46BC
		public new vtkGraphicsFactory NewInstance()
		{
			vtkGraphicsFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014C56 RID: 85078
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGraphicsFactory_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C57 RID: 85079 RVA: 0x001D6518 File Offset: 0x001D4718
		public new static vtkGraphicsFactory SafeDownCast(vtkObjectBase o)
		{
			vtkGraphicsFactory vtkGraphicsFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphicsFactory = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphicsFactory.Register(null);
				}
			}
			return vtkGraphicsFactory;
		}

		// Token: 0x06014C58 RID: 85080
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphicsFactory_SetOffScreenOnlyMode_12(int use);

		/// <summary>
		/// This option enables the off-screen only mode. In this mode no X calls will
		/// be made even when interactor is used.
		/// </summary>
		// Token: 0x06014C59 RID: 85081 RVA: 0x001D6597 File Offset: 0x001D4797
		public static void SetOffScreenOnlyMode(int use)
		{
			vtkGraphicsFactory.vtkGraphicsFactory_SetOffScreenOnlyMode_12(use);
		}

		// Token: 0x06014C5A RID: 85082
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGraphicsFactory_SetUseMesaClasses_13(int use);

		/// <summary>
		/// This option enables the creation of Mesa classes
		/// instead of the OpenGL classes when using mangled Mesa.
		/// </summary>
		// Token: 0x06014C5B RID: 85083 RVA: 0x001D65A1 File Offset: 0x001D47A1
		public static void SetUseMesaClasses(int use)
		{
			vtkGraphicsFactory.vtkGraphicsFactory_SetUseMesaClasses_13(use);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017FF RID: 6143
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphicsFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001800 RID: 6144
		public new static readonly string MRClassNameKey = "class vtkGraphicsFactory";
	}
}
