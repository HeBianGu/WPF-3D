using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMapToRGBA
	/// </summary>
	/// <remarks>
	///    map the input image through a lookup table
	///
	/// This filter has been replaced by vtkImageMapToColors, which provided
	/// additional features.  Use vtkImageMapToColors instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLookupTable
	/// </seealso>
	// Token: 0x020003F1 RID: 1009
	public class vtkImageMapToRGBA : vtkImageMapToColors
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C11D RID: 49437 RVA: 0x0010CF5F File Offset: 0x0010B15F
		static vtkImageMapToRGBA()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToRGBA.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToRGBA"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C11E RID: 49438 RVA: 0x0010CF87 File Offset: 0x0010B187
		public vtkImageMapToRGBA(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C11F RID: 49439
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToRGBA_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C120 RID: 49440 RVA: 0x0010CF98 File Offset: 0x0010B198
		public new static vtkImageMapToRGBA New()
		{
			vtkImageMapToRGBA result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C121 RID: 49441 RVA: 0x0010CFEC File Offset: 0x0010B1EC
		public vtkImageMapToRGBA() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMapToRGBA.vtkImageMapToRGBA_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C122 RID: 49442 RVA: 0x0010D030 File Offset: 0x0010B230
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C123 RID: 49443
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToRGBA_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C124 RID: 49444 RVA: 0x0010D03C File Offset: 0x0010B23C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C125 RID: 49445
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMapToRGBA_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C126 RID: 49446 RVA: 0x0010D05C File Offset: 0x0010B25C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C127 RID: 49447
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToRGBA_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C128 RID: 49448 RVA: 0x0010D078 File Offset: 0x0010B278
		public override int IsA(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C129 RID: 49449
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMapToRGBA_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C12A RID: 49450 RVA: 0x0010D098 File Offset: 0x0010B298
		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_IsTypeOf_04(type);
		}

		// Token: 0x0600C12B RID: 49451
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToRGBA_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C12C RID: 49452 RVA: 0x0010D0B4 File Offset: 0x0010B2B4
		public new vtkImageMapToRGBA NewInstance()
		{
			vtkImageMapToRGBA result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C12D RID: 49453
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMapToRGBA_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C12E RID: 49454 RVA: 0x0010D110 File Offset: 0x0010B310
		public new static vtkImageMapToRGBA SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToRGBA vtkImageMapToRGBA = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToRGBA = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToRGBA.Register(null);
				}
			}
			return vtkImageMapToRGBA;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4F RID: 3663
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToRGBA";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E50 RID: 3664
		public new static readonly string MRClassNameKey = "class vtkImageMapToRGBA";
	}
}
