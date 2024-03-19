using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatrixToLinearTransform
	/// </summary>
	/// <remarks>
	///    convert a matrix to a transform
	///
	/// This is a very simple class which allows a vtkMatrix4x4 to be used in
	/// place of a vtkLinearTransform or vtkAbstractTransform.  For example,
	/// if you use it as a proxy between a matrix and vtkTransformPolyDataFilter
	/// then any modifications to the matrix will automatically be reflected in
	/// the output of the filter.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTransform vtkMatrix4x4 vtkMatrixToHomogeneousTransform
	/// </seealso>
	// Token: 0x02000B0B RID: 2827
	public class vtkMatrixToLinearTransform : vtkLinearTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DB19 RID: 121625 RVA: 0x0029EF27 File Offset: 0x0029D127
		static vtkMatrixToLinearTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixToLinearTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixToLinearTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB1A RID: 121626 RVA: 0x0029EF4F File Offset: 0x0029D14F
		public vtkMatrixToLinearTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DB1B RID: 121627
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToLinearTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB1C RID: 121628 RVA: 0x0029EF60 File Offset: 0x0029D160
		public new static vtkMatrixToLinearTransform New()
		{
			vtkMatrixToLinearTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB1D RID: 121629 RVA: 0x0029EFB4 File Offset: 0x0029D1B4
		public vtkMatrixToLinearTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB1E RID: 121630 RVA: 0x0029EFF8 File Offset: 0x0029D1F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DB1F RID: 121631
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToLinearTransform_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the input matrix.  Any modifications to the matrix will be
		/// reflected in the transformation.
		/// </summary>
		// Token: 0x0601DB20 RID: 121632 RVA: 0x0029F004 File Offset: 0x0029D204
		public virtual vtkMatrix4x4 GetInput()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DB21 RID: 121633
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMatrixToLinearTransform_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Get the MTime: this is the bit of magic that makes everything work.
		/// </summary>
		// Token: 0x0601DB22 RID: 121634 RVA: 0x0029F074 File Offset: 0x0029D274
		public override ulong GetMTime()
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601DB23 RID: 121635
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB24 RID: 121636 RVA: 0x0029F094 File Offset: 0x0029D294
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DB25 RID: 121637
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB26 RID: 121638 RVA: 0x0029F0B4 File Offset: 0x0029D2B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601DB27 RID: 121639
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixToLinearTransform_Inverse_05(HandleRef pThis);

		/// <summary>
		/// The input matrix is left as-is, but the transformation matrix
		/// is inverted.
		/// </summary>
		// Token: 0x0601DB28 RID: 121640 RVA: 0x0029F0CE File Offset: 0x0029D2CE
		public override void Inverse()
		{
			vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_Inverse_05(base.GetCppThis());
		}

		// Token: 0x0601DB29 RID: 121641
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixToLinearTransform_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB2A RID: 121642 RVA: 0x0029F0E0 File Offset: 0x0029D2E0
		public override int IsA(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601DB2B RID: 121643
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixToLinearTransform_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB2C RID: 121644 RVA: 0x0029F100 File Offset: 0x0029D300
		public new static int IsTypeOf(string type)
		{
			return vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_IsTypeOf_07(type);
		}

		// Token: 0x0601DB2D RID: 121645
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToLinearTransform_MakeTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a new transform of the same type.
		/// </summary>
		// Token: 0x0601DB2E RID: 121646 RVA: 0x0029F11C File Offset: 0x0029D31C
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_MakeTransform_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB2F RID: 121647
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToLinearTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB30 RID: 121648 RVA: 0x0029F178 File Offset: 0x0029D378
		public new vtkMatrixToLinearTransform NewInstance()
		{
			vtkMatrixToLinearTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB31 RID: 121649
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToLinearTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB32 RID: 121650 RVA: 0x0029F1D4 File Offset: 0x0029D3D4
		public new static vtkMatrixToLinearTransform SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixToLinearTransform vtkMatrixToLinearTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixToLinearTransform = (vtkMatrixToLinearTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixToLinearTransform.Register(null);
				}
			}
			return vtkMatrixToLinearTransform;
		}

		// Token: 0x0601DB33 RID: 121651
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixToLinearTransform_SetInput_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input matrix.  Any modifications to the matrix will be
		/// reflected in the transformation.
		/// </summary>
		// Token: 0x0601DB34 RID: 121652 RVA: 0x0029F254 File Offset: 0x0029D454
		public virtual void SetInput(vtkMatrix4x4 arg0)
		{
			vtkMatrixToLinearTransform.vtkMatrixToLinearTransform_SetInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F47 RID: 8007
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixToLinearTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F48 RID: 8008
		public new static readonly string MRClassNameKey = "class vtkMatrixToLinearTransform";
	}
}
