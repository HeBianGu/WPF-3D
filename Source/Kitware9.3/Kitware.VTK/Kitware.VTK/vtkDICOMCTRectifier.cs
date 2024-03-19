using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	/// \class vtkDICOMCTRectifier
	/// \brief Prepare a CT for 3D processing
	///
	/// This class will identify gantry-tilted CT images and resample them
	/// into a rectangular volume.  This is often a necessary step prior to
	/// volume rendering or other forms of 3D rendering.
	/// </summary>
	// Token: 0x02000043 RID: 67
	public class vtkDICOMCTRectifier : vtkDICOMAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000C14 RID: 3092 RVA: 0x0001825A File Offset: 0x0001645A
		static vtkDICOMCTRectifier()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMCTRectifier.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCTRectifier"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000C15 RID: 3093 RVA: 0x00018282 File Offset: 0x00016482
		public vtkDICOMCTRectifier(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000C16 RID: 3094
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTRectifier_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C17 RID: 3095 RVA: 0x00018290 File Offset: 0x00016490
		public new static vtkDICOMCTRectifier New()
		{
			vtkDICOMCTRectifier result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTRectifier.vtkDICOMCTRectifier_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C18 RID: 3096 RVA: 0x000182E4 File Offset: 0x000164E4
		public vtkDICOMCTRectifier() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMCTRectifier.vtkDICOMCTRectifier_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000C19 RID: 3097 RVA: 0x00018328 File Offset: 0x00016528
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000C1A RID: 3098
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDICOMCTRectifier_GetGantryDetectorTilt_01(HandleRef volumeMatrix);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C1B RID: 3099 RVA: 0x00018334 File Offset: 0x00016534
		public static double GetGantryDetectorTilt(vtkMatrix4x4 volumeMatrix)
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetGantryDetectorTilt_01((volumeMatrix == null) ? default(HandleRef) : volumeMatrix.GetCppThis());
		}

		// Token: 0x06000C1C RID: 3100
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTRectifier_GetInterpolationMode_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C1D RID: 3101 RVA: 0x00018364 File Offset: 0x00016564
		public int GetInterpolationMode()
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetInterpolationMode_02(base.GetCppThis());
		}

		// Token: 0x06000C1E RID: 3102
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCTRectifier_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C1F RID: 3103 RVA: 0x00018384 File Offset: 0x00016584
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06000C20 RID: 3104
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMCTRectifier_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C21 RID: 3105 RVA: 0x000183A4 File Offset: 0x000165A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06000C22 RID: 3106
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTRectifier_GetRectifiedMatrix_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C23 RID: 3107 RVA: 0x000183C0 File Offset: 0x000165C0
		public vtkMatrix4x4 GetRectifiedMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetRectifiedMatrix_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000C24 RID: 3108
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTRectifier_GetReverse_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C25 RID: 3109 RVA: 0x00018430 File Offset: 0x00016630
		public int GetReverse()
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetReverse_06(base.GetCppThis());
		}

		// Token: 0x06000C26 RID: 3110
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTRectifier_GetVolumeMatrix_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C27 RID: 3111 RVA: 0x00018450 File Offset: 0x00016650
		public vtkMatrix4x4 GetVolumeMatrix()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTRectifier.vtkDICOMCTRectifier_GetVolumeMatrix_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06000C28 RID: 3112
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTRectifier_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C29 RID: 3113 RVA: 0x000184C0 File Offset: 0x000166C0
		public override int IsA(string type)
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06000C2A RID: 3114
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMCTRectifier_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C2B RID: 3115 RVA: 0x000184E0 File Offset: 0x000166E0
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMCTRectifier.vtkDICOMCTRectifier_IsTypeOf_09(type);
		}

		// Token: 0x06000C2C RID: 3116
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTRectifier_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C2D RID: 3117 RVA: 0x000184FC File Offset: 0x000166FC
		public new vtkDICOMCTRectifier NewInstance()
		{
			vtkDICOMCTRectifier result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTRectifier.vtkDICOMCTRectifier_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C2E RID: 3118
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_ReverseOff_12(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C2F RID: 3119 RVA: 0x00018556 File Offset: 0x00016756
		public void ReverseOff()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_ReverseOff_12(base.GetCppThis());
		}

		// Token: 0x06000C30 RID: 3120
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_ReverseOn_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C31 RID: 3121 RVA: 0x00018565 File Offset: 0x00016765
		public void ReverseOn()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_ReverseOn_13(base.GetCppThis());
		}

		// Token: 0x06000C32 RID: 3122
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMCTRectifier_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C33 RID: 3123 RVA: 0x00018574 File Offset: 0x00016774
		public new static vtkDICOMCTRectifier SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMCTRectifier vtkDICOMCTRectifier = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMCTRectifier.vtkDICOMCTRectifier_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMCTRectifier = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMCTRectifier.Register(null);
				}
			}
			return vtkDICOMCTRectifier;
		}

		// Token: 0x06000C34 RID: 3124
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetInterpolationMode_15(HandleRef pThis, int t);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C35 RID: 3125 RVA: 0x000185F3 File Offset: 0x000167F3
		public void SetInterpolationMode(int t)
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetInterpolationMode_15(base.GetCppThis(), t);
		}

		// Token: 0x06000C36 RID: 3126
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToCubic_16(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C37 RID: 3127 RVA: 0x00018603 File Offset: 0x00016803
		public void SetInterpolationModeToCubic()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetInterpolationModeToCubic_16(base.GetCppThis());
		}

		// Token: 0x06000C38 RID: 3128
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToLinear_17(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C39 RID: 3129 RVA: 0x00018612 File Offset: 0x00016812
		public void SetInterpolationModeToLinear()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetInterpolationModeToLinear_17(base.GetCppThis());
		}

		// Token: 0x06000C3A RID: 3130
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToNearest_18(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C3B RID: 3131 RVA: 0x00018621 File Offset: 0x00016821
		public void SetInterpolationModeToNearest()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetInterpolationModeToNearest_18(base.GetCppThis());
		}

		// Token: 0x06000C3C RID: 3132
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToWindowedSinc_19(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C3D RID: 3133 RVA: 0x00018630 File Offset: 0x00016830
		public void SetInterpolationModeToWindowedSinc()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetInterpolationModeToWindowedSinc_19(base.GetCppThis());
		}

		// Token: 0x06000C3E RID: 3134
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetReverse_20(HandleRef pThis, int v);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C3F RID: 3135 RVA: 0x0001863F File Offset: 0x0001683F
		public void SetReverse(int v)
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetReverse_20(base.GetCppThis(), v);
		}

		// Token: 0x06000C40 RID: 3136
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_SetVolumeMatrix_21(HandleRef pThis, HandleRef matrix);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C41 RID: 3137 RVA: 0x00018650 File Offset: 0x00016850
		public void SetVolumeMatrix(vtkMatrix4x4 matrix)
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_SetVolumeMatrix_21(base.GetCppThis(), (matrix == null) ? default(HandleRef) : matrix.GetCppThis());
		}

		// Token: 0x06000C42 RID: 3138
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMCTRectifier_UpdateMatrix_22(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06000C43 RID: 3139 RVA: 0x0001867F File Offset: 0x0001687F
		public void UpdateMatrix()
		{
			vtkDICOMCTRectifier.vtkDICOMCTRectifier_UpdateMatrix_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B7 RID: 951
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCTRectifier";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003B8 RID: 952
		public new static readonly string MRClassNameKey = "class vtkDICOMCTRectifier";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000044 RID: 68
		public enum Cubic_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040003BA RID: 954
			Cubic = 2,
			/// <summary>enum member</summary>
			// Token: 0x040003BB RID: 955
			Linear = 1,
			/// <summary>enum member</summary>
			// Token: 0x040003BC RID: 956
			Nearest = 0,
			/// <summary>enum member</summary>
			// Token: 0x040003BD RID: 957
			WindowedSinc = 3
		}
	}
}
