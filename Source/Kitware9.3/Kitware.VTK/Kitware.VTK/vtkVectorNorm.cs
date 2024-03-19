using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVectorNorm
	/// </summary>
	/// <remarks>
	///    generate scalars from Euclidean norm of vectors
	///
	/// vtkVectorNorm is a filter that generates scalar values by computing
	/// Euclidean norm of vector triplets. Scalars can be normalized
	/// 0&lt;=s&lt;=1 if desired.
	///
	/// Note that this filter operates on point or cell attribute data, or
	/// both.  By default, the filter operates on both point and cell data
	/// if vector point and cell data, respectively, are available from the
	/// input. Alternatively, you can choose to generate scalar norm values
	/// for just cell or point data.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x020009C0 RID: 2496
	public class vtkVectorNorm : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A12F RID: 106799 RVA: 0x002424EC File Offset: 0x002406EC
		static vtkVectorNorm()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorNorm.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorNorm"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A130 RID: 106800 RVA: 0x00242514 File Offset: 0x00240714
		public vtkVectorNorm(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A131 RID: 106801
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorNorm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A132 RID: 106802 RVA: 0x00242524 File Offset: 0x00240724
		public new static vtkVectorNorm New()
		{
			vtkVectorNorm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A133 RID: 106803 RVA: 0x00242578 File Offset: 0x00240778
		public vtkVectorNorm() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVectorNorm.vtkVectorNorm_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A134 RID: 106804 RVA: 0x002425BC File Offset: 0x002407BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A135 RID: 106805
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorNorm_GetAttributeMode_01(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A136 RID: 106806 RVA: 0x002425C8 File Offset: 0x002407C8
		public virtual int GetAttributeMode()
		{
			return vtkVectorNorm.vtkVectorNorm_GetAttributeMode_01(base.GetCppThis());
		}

		// Token: 0x0601A137 RID: 106807
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorNorm_GetAttributeModeAsString_02(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A138 RID: 106808 RVA: 0x002425E8 File Offset: 0x002407E8
		public string GetAttributeModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkVectorNorm.vtkVectorNorm_GetAttributeModeAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601A139 RID: 106809
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorNorm_GetNormalize_03(HandleRef pThis);

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A13A RID: 106810 RVA: 0x00242624 File Offset: 0x00240824
		public virtual int GetNormalize()
		{
			return vtkVectorNorm.vtkVectorNorm_GetNormalize_03(base.GetCppThis());
		}

		// Token: 0x0601A13B RID: 106811
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorNorm_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A13C RID: 106812 RVA: 0x00242644 File Offset: 0x00240844
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A13D RID: 106813
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorNorm_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A13E RID: 106814 RVA: 0x00242664 File Offset: 0x00240864
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601A13F RID: 106815
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorNorm_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A140 RID: 106816 RVA: 0x00242680 File Offset: 0x00240880
		public override int IsA(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A141 RID: 106817
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorNorm_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A142 RID: 106818 RVA: 0x002426A0 File Offset: 0x002408A0
		public new static int IsTypeOf(string type)
		{
			return vtkVectorNorm.vtkVectorNorm_IsTypeOf_07(type);
		}

		// Token: 0x0601A143 RID: 106819
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorNorm_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A144 RID: 106820 RVA: 0x002426BC File Offset: 0x002408BC
		public new vtkVectorNorm NewInstance()
		{
			vtkVectorNorm result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A145 RID: 106821
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_NormalizeOff_10(HandleRef pThis);

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A146 RID: 106822 RVA: 0x00242716 File Offset: 0x00240916
		public virtual void NormalizeOff()
		{
			vtkVectorNorm.vtkVectorNorm_NormalizeOff_10(base.GetCppThis());
		}

		// Token: 0x0601A147 RID: 106823
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_NormalizeOn_11(HandleRef pThis);

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A148 RID: 106824 RVA: 0x00242725 File Offset: 0x00240925
		public virtual void NormalizeOn()
		{
			vtkVectorNorm.vtkVectorNorm_NormalizeOn_11(base.GetCppThis());
		}

		// Token: 0x0601A149 RID: 106825
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorNorm_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A14A RID: 106826 RVA: 0x00242734 File Offset: 0x00240934
		public new static vtkVectorNorm SafeDownCast(vtkObjectBase o)
		{
			vtkVectorNorm vtkVectorNorm = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorNorm.vtkVectorNorm_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorNorm = (vtkVectorNorm)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorNorm.Register(null);
				}
			}
			return vtkVectorNorm;
		}

		// Token: 0x0601A14B RID: 106827
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_SetAttributeMode_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A14C RID: 106828 RVA: 0x002427B3 File Offset: 0x002409B3
		public virtual void SetAttributeMode(int _arg)
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeMode_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A14D RID: 106829
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_SetAttributeModeToDefault_14(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A14E RID: 106830 RVA: 0x002427C3 File Offset: 0x002409C3
		public void SetAttributeModeToDefault()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToDefault_14(base.GetCppThis());
		}

		// Token: 0x0601A14F RID: 106831
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_SetAttributeModeToUseCellData_15(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A150 RID: 106832 RVA: 0x002427D2 File Offset: 0x002409D2
		public void SetAttributeModeToUseCellData()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToUseCellData_15(base.GetCppThis());
		}

		// Token: 0x0601A151 RID: 106833
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_SetAttributeModeToUsePointData_16(HandleRef pThis);

		/// <summary>
		/// Control how the filter works to generate scalar data from the
		/// input vector data. By default, (AttributeModeToDefault) the
		/// filter will generate the scalar norm for point and cell data (if
		/// vector data present in the input). Alternatively, you can
		/// explicitly set the filter to generate point data
		/// (AttributeModeToUsePointData) or cell data
		/// (AttributeModeToUseCellData).
		/// </summary>
		// Token: 0x0601A152 RID: 106834 RVA: 0x002427E1 File Offset: 0x002409E1
		public void SetAttributeModeToUsePointData()
		{
			vtkVectorNorm.vtkVectorNorm_SetAttributeModeToUsePointData_16(base.GetCppThis());
		}

		// Token: 0x0601A153 RID: 106835
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorNorm_SetNormalize_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Construct with normalize flag off.
		/// </summary>
		// Token: 0x0601A154 RID: 106836 RVA: 0x002427F0 File Offset: 0x002409F0
		public virtual void SetNormalize(int _arg)
		{
			vtkVectorNorm.vtkVectorNorm_SetNormalize_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C49 RID: 7241
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorNorm";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C4A RID: 7242
		public new static readonly string MRClassNameKey = "class vtkVectorNorm";
	}
}
