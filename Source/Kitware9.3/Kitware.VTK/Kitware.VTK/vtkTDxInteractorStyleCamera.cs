using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTDxInteractorStyleCamera
	/// </summary>
	/// <remarks>
	///    interactive manipulation of the camera with a 3DConnexion device
	///
	///
	/// vtkTDxInteractorStyleCamera allows the end-user to manipulate the camera
	/// with a 3DConnexion device.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInteractorStyle vtkRenderWindowInteractor
	/// vtkTDxInteractorStyle
	/// </seealso>
	// Token: 0x02000818 RID: 2072
	public class vtkTDxInteractorStyleCamera : vtkTDxInteractorStyle
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060154ED RID: 87277 RVA: 0x001E2FC3 File Offset: 0x001E11C3
		static vtkTDxInteractorStyleCamera()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTDxInteractorStyleCamera.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTDxInteractorStyleCamera"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060154EE RID: 87278 RVA: 0x001E2FEB File Offset: 0x001E11EB
		public vtkTDxInteractorStyleCamera(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060154EF RID: 87279
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154F0 RID: 87280 RVA: 0x001E2FFC File Offset: 0x001E11FC
		public new static vtkTDxInteractorStyleCamera New()
		{
			vtkTDxInteractorStyleCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154F1 RID: 87281 RVA: 0x001E3050 File Offset: 0x001E1250
		public vtkTDxInteractorStyleCamera() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060154F2 RID: 87282 RVA: 0x001E3094 File Offset: 0x001E1294
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060154F3 RID: 87283
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyleCamera_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154F4 RID: 87284 RVA: 0x001E30A0 File Offset: 0x001E12A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060154F5 RID: 87285
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTDxInteractorStyleCamera_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154F6 RID: 87286 RVA: 0x001E30C0 File Offset: 0x001E12C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060154F7 RID: 87287
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyleCamera_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154F8 RID: 87288 RVA: 0x001E30DC File Offset: 0x001E12DC
		public override int IsA(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060154F9 RID: 87289
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTDxInteractorStyleCamera_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154FA RID: 87290 RVA: 0x001E30FC File Offset: 0x001E12FC
		public new static int IsTypeOf(string type)
		{
			return vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_IsTypeOf_04(type);
		}

		// Token: 0x060154FB RID: 87291
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154FC RID: 87292 RVA: 0x001E3118 File Offset: 0x001E1318
		public new vtkTDxInteractorStyleCamera NewInstance()
		{
			vtkTDxInteractorStyleCamera result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060154FD RID: 87293
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTDxInteractorStyleCamera_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060154FE RID: 87294 RVA: 0x001E3174 File Offset: 0x001E1374
		public new static vtkTDxInteractorStyleCamera SafeDownCast(vtkObjectBase o)
		{
			vtkTDxInteractorStyleCamera vtkTDxInteractorStyleCamera = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTDxInteractorStyleCamera.vtkTDxInteractorStyleCamera_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTDxInteractorStyleCamera = (vtkTDxInteractorStyleCamera)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTDxInteractorStyleCamera.Register(null);
				}
			}
			return vtkTDxInteractorStyleCamera;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001878 RID: 6264
		public new const string MRFullTypeName = "Kitware.VTK.vtkTDxInteractorStyleCamera";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001879 RID: 6265
		public new static readonly string MRClassNameKey = "class vtkTDxInteractorStyleCamera";
	}
}
