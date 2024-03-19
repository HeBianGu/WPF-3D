using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMToRAS
	/// \brief Convert DICOM orientation to RAS orientation
	///
	/// This class will modify an image and its position-and-orientation matrix
	/// so that the patient coordinate system follows the conventions of NIFTI
	/// and MINC, i.e. the x, y, and z axes will point in the right, anterior,
	/// and superior directions respectively.  Optionally, the row and column
	/// ordering of the image will also be modified so that the row direction
	/// preferentially points right or anterior, and the column direction
	/// preferentially points superior or anterior.
	/// </summary>
	// Token: 0x02000042 RID: 66
	public class vtkDICOMToRAS : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000BD8 RID: 3032 RVA: 0x00017DA5 File Offset: 0x00015FA5
		static vtkDICOMToRAS()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMToRAS.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMToRAS"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000BD9 RID: 3033 RVA: 0x00017DCD File Offset: 0x00015FCD
		public vtkDICOMToRAS(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000BDA RID: 3034
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMToRAS_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BDB RID: 3035 RVA: 0x00017DDC File Offset: 0x00015FDC
		public new static vtkDICOMToRAS New()
		{
			vtkDICOMToRAS result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMToRAS.vtkDICOMToRAS_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BDC RID: 3036 RVA: 0x00017E30 File Offset: 0x00016030
		public vtkDICOMToRAS() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMToRAS.vtkDICOMToRAS_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000BDD RID: 3037 RVA: 0x00017E74 File Offset: 0x00016074
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000BDE RID: 3038
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_AllowColumnReorderingOff_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BDF RID: 3039 RVA: 0x00017E7F File Offset: 0x0001607F
		public void AllowColumnReorderingOff()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_AllowColumnReorderingOff_01(base.GetCppThis());
		}

		// Token: 0x06000BE0 RID: 3040
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_AllowColumnReorderingOn_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BE1 RID: 3041 RVA: 0x00017E8E File Offset: 0x0001608E
		public void AllowColumnReorderingOn()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_AllowColumnReorderingOn_02(base.GetCppThis());
		}

		// Token: 0x06000BE2 RID: 3042
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_AllowRowReorderingOff_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BE3 RID: 3043 RVA: 0x00017E9D File Offset: 0x0001609D
		public void AllowRowReorderingOff()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_AllowRowReorderingOff_03(base.GetCppThis());
		}

		// Token: 0x06000BE4 RID: 3044
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_AllowRowReorderingOn_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BE5 RID: 3045 RVA: 0x00017EAC File Offset: 0x000160AC
		public void AllowRowReorderingOn()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_AllowRowReorderingOn_04(base.GetCppThis());
		}

		// Token: 0x06000BE6 RID: 3046
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_GetAllowColumnReordering_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BE7 RID: 3047 RVA: 0x00017EBC File Offset: 0x000160BC
		public int GetAllowColumnReordering()
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetAllowColumnReordering_05(base.GetCppThis());
		}

		// Token: 0x06000BE8 RID: 3048
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_GetAllowRowReordering_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BE9 RID: 3049 RVA: 0x00017EDC File Offset: 0x000160DC
		public int GetAllowRowReordering()
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetAllowRowReordering_06(base.GetCppThis());
		}

		// Token: 0x06000BEA RID: 3050
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMToRAS_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BEB RID: 3051 RVA: 0x00017EFC File Offset: 0x000160FC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06000BEC RID: 3052
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMToRAS_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BED RID: 3053 RVA: 0x00017F1C File Offset: 0x0001611C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06000BEE RID: 3054
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMToRAS_GetPatientMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BEF RID: 3055 RVA: 0x00017F38 File Offset: 0x00016138
		public vtkMatrix4x4 GetPatientMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMToRAS.vtkDICOMToRAS_GetPatientMatrix_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06000BF0 RID: 3056
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMToRAS_GetRASMatrix_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BF1 RID: 3057 RVA: 0x00017FA8 File Offset: 0x000161A8
		public vtkMatrix4x4 GetRASMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMToRAS.vtkDICOMToRAS_GetRASMatrix_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x06000BF2 RID: 3058
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_GetRASMatrixHasPosition_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BF3 RID: 3059 RVA: 0x00018018 File Offset: 0x00016218
		public int GetRASMatrixHasPosition()
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetRASMatrixHasPosition_11(base.GetCppThis());
		}

		// Token: 0x06000BF4 RID: 3060
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_GetRASToDICOM_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BF5 RID: 3061 RVA: 0x00018038 File Offset: 0x00016238
		public int GetRASToDICOM()
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_GetRASToDICOM_12(base.GetCppThis());
		}

		// Token: 0x06000BF6 RID: 3062
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BF7 RID: 3063 RVA: 0x00018058 File Offset: 0x00016258
		public override int IsA(string type)
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06000BF8 RID: 3064
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMToRAS_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BF9 RID: 3065 RVA: 0x00018078 File Offset: 0x00016278
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMToRAS.vtkDICOMToRAS_IsTypeOf_14(type);
		}

		// Token: 0x06000BFA RID: 3066
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMToRAS_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BFB RID: 3067 RVA: 0x00018094 File Offset: 0x00016294
		public new vtkDICOMToRAS NewInstance()
		{
			vtkDICOMToRAS result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMToRAS.vtkDICOMToRAS_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000BFC RID: 3068
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_RASMatrixHasPositionOff_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BFD RID: 3069 RVA: 0x000180EE File Offset: 0x000162EE
		public void RASMatrixHasPositionOff()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_RASMatrixHasPositionOff_17(base.GetCppThis());
		}

		// Token: 0x06000BFE RID: 3070
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_RASMatrixHasPositionOn_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000BFF RID: 3071 RVA: 0x000180FD File Offset: 0x000162FD
		public void RASMatrixHasPositionOn()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_RASMatrixHasPositionOn_18(base.GetCppThis());
		}

		// Token: 0x06000C00 RID: 3072
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_RASToDICOMOff_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C01 RID: 3073 RVA: 0x0001810C File Offset: 0x0001630C
		public void RASToDICOMOff()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_RASToDICOMOff_19(base.GetCppThis());
		}

		// Token: 0x06000C02 RID: 3074
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_RASToDICOMOn_20(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C03 RID: 3075 RVA: 0x0001811B File Offset: 0x0001631B
		public void RASToDICOMOn()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_RASToDICOMOn_20(base.GetCppThis());
		}

		// Token: 0x06000C04 RID: 3076
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMToRAS_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C05 RID: 3077 RVA: 0x0001812C File Offset: 0x0001632C
		public new static vtkDICOMToRAS SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMToRAS vtkDICOMToRAS = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMToRAS.vtkDICOMToRAS_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMToRAS = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMToRAS.Register(null);
				}
			}
			return vtkDICOMToRAS;
		}

		// Token: 0x06000C06 RID: 3078
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetAllowColumnReordering_22(HandleRef pThis, int v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C07 RID: 3079 RVA: 0x000181AB File Offset: 0x000163AB
		public void SetAllowColumnReordering(int v)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetAllowColumnReordering_22(base.GetCppThis(), v);
		}

		// Token: 0x06000C08 RID: 3080
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetAllowRowReordering_23(HandleRef pThis, int v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C09 RID: 3081 RVA: 0x000181BB File Offset: 0x000163BB
		public void SetAllowRowReordering(int v)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetAllowRowReordering_23(base.GetCppThis(), v);
		}

		// Token: 0x06000C0A RID: 3082
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetPatientMatrix_24(HandleRef pThis, HandleRef matrix);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C0B RID: 3083 RVA: 0x000181CC File Offset: 0x000163CC
		public void SetPatientMatrix(vtkMatrix4x4 matrix)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetPatientMatrix_24(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06000C0C RID: 3084
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetRASMatrix_25(HandleRef pThis, HandleRef matrix);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C0D RID: 3085 RVA: 0x000181FC File Offset: 0x000163FC
		public void SetRASMatrix(vtkMatrix4x4 matrix)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetRASMatrix_25(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06000C0E RID: 3086
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetRASMatrixHasPosition_26(HandleRef pThis, int v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C0F RID: 3087 RVA: 0x0001822B File Offset: 0x0001642B
		public void SetRASMatrixHasPosition(int v)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetRASMatrixHasPosition_26(base.GetCppThis(), v);
		}

		// Token: 0x06000C10 RID: 3088
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_SetRASToDICOM_27(HandleRef pThis, int v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C11 RID: 3089 RVA: 0x0001823B File Offset: 0x0001643B
		public void SetRASToDICOM(int v)
		{
			vtkDICOMToRAS.vtkDICOMToRAS_SetRASToDICOM_27(base.GetCppThis(), v);
		}

		// Token: 0x06000C12 RID: 3090
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMToRAS_UpdateMatrix_28(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C13 RID: 3091 RVA: 0x0001824B File Offset: 0x0001644B
		public void UpdateMatrix()
		{
			vtkDICOMToRAS.vtkDICOMToRAS_UpdateMatrix_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B5 RID: 949
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMToRAS";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B6 RID: 950
		public new static readonly string MRClassNameKey = "class vtkDICOMToRAS";
	}
}
