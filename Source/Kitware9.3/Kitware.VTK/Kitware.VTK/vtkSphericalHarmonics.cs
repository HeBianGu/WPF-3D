using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSphericalHarmonics
	/// </summary>
	/// <remarks>
	///    compute spherical harmonics of an equirectangular projection image
	///
	/// vtkSphericalHarmonics is a filter that computes spherical harmonics of an
	/// equirectangular projection image representing a 360 degree image.
	/// Its output is a vtkTable containing the third degree spherical harmonics coefficients.
	/// This filter expects the image data to be a RGB image.
	/// 8-bits images are expected to be sRGB encoded and other formats are expected to be in
	/// linear color space.
	/// </remarks>
	// Token: 0x020008E0 RID: 2272
	public class vtkSphericalHarmonics : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017785 RID: 96133 RVA: 0x0020EEAB File Offset: 0x0020D0AB
		static vtkSphericalHarmonics()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSphericalHarmonics.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphericalHarmonics"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017786 RID: 96134 RVA: 0x0020EED3 File Offset: 0x0020D0D3
		public vtkSphericalHarmonics(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017787 RID: 96135
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalHarmonics_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017788 RID: 96136 RVA: 0x0020EEE4 File Offset: 0x0020D0E4
		public new static vtkSphericalHarmonics New()
		{
			vtkSphericalHarmonics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalHarmonics.vtkSphericalHarmonics_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalHarmonics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017789 RID: 96137 RVA: 0x0020EF38 File Offset: 0x0020D138
		public vtkSphericalHarmonics() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSphericalHarmonics.vtkSphericalHarmonics_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601778A RID: 96138 RVA: 0x0020EF7C File Offset: 0x0020D17C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601778B RID: 96139
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalHarmonics_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601778C RID: 96140 RVA: 0x0020EF88 File Offset: 0x0020D188
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSphericalHarmonics.vtkSphericalHarmonics_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601778D RID: 96141
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSphericalHarmonics_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601778E RID: 96142 RVA: 0x0020EFA8 File Offset: 0x0020D1A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSphericalHarmonics.vtkSphericalHarmonics_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601778F RID: 96143
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalHarmonics_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017790 RID: 96144 RVA: 0x0020EFC4 File Offset: 0x0020D1C4
		public override int IsA(string type)
		{
			return vtkSphericalHarmonics.vtkSphericalHarmonics_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017791 RID: 96145
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSphericalHarmonics_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017792 RID: 96146 RVA: 0x0020EFE4 File Offset: 0x0020D1E4
		public new static int IsTypeOf(string type)
		{
			return vtkSphericalHarmonics.vtkSphericalHarmonics_IsTypeOf_04(type);
		}

		// Token: 0x06017793 RID: 96147
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalHarmonics_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017794 RID: 96148 RVA: 0x0020F000 File Offset: 0x0020D200
		public new vtkSphericalHarmonics NewInstance()
		{
			vtkSphericalHarmonics result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalHarmonics.vtkSphericalHarmonics_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSphericalHarmonics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017795 RID: 96149
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSphericalHarmonics_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017796 RID: 96150 RVA: 0x0020F05C File Offset: 0x0020D25C
		public new static vtkSphericalHarmonics SafeDownCast(vtkObjectBase o)
		{
			vtkSphericalHarmonics vtkSphericalHarmonics = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSphericalHarmonics.vtkSphericalHarmonics_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSphericalHarmonics = (vtkSphericalHarmonics)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSphericalHarmonics.Register(null);
				}
			}
			return vtkSphericalHarmonics;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A35 RID: 6709
		public new const string MRFullTypeName = "Kitware.VTK.vtkSphericalHarmonics";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A36 RID: 6710
		public new static readonly string MRClassNameKey = "class vtkSphericalHarmonics";
	}
}
