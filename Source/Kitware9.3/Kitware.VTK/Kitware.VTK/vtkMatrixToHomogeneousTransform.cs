using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatrixToHomogeneousTransform
	/// </summary>
	/// <remarks>
	///    convert a matrix to a transform
	///
	/// This is a very simple class which allows a vtkMatrix4x4 to be used in
	/// place of a vtkHomogeneousTransform or vtkAbstractTransform.  For example,
	/// if you use it as a proxy between a matrix and vtkTransformPolyDataFilter
	/// then any modifications to the matrix will automatically be reflected in
	/// the output of the filter.
	/// </remarks>
	/// <seealso>
	///
	/// vtkPerspectiveTransform vtkMatrix4x4 vtkMatrixToLinearTransform
	/// </seealso>
	// Token: 0x02000B0A RID: 2826
	public class vtkMatrixToHomogeneousTransform : vtkHomogeneousTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601DAFD RID: 121597 RVA: 0x0029EBCB File Offset: 0x0029CDCB
		static vtkMatrixToHomogeneousTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatrixToHomogeneousTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatrixToHomogeneousTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601DAFE RID: 121598 RVA: 0x0029EBF3 File Offset: 0x0029CDF3
		public vtkMatrixToHomogeneousTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601DAFF RID: 121599
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB00 RID: 121600 RVA: 0x0029EC04 File Offset: 0x0029CE04
		public new static vtkMatrixToHomogeneousTransform New()
		{
			vtkMatrixToHomogeneousTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB01 RID: 121601 RVA: 0x0029EC58 File Offset: 0x0029CE58
		public vtkMatrixToHomogeneousTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601DB02 RID: 121602 RVA: 0x0029EC9C File Offset: 0x0029CE9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601DB03 RID: 121603
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB04 RID: 121604 RVA: 0x0029ECA8 File Offset: 0x0029CEA8
		public virtual vtkMatrix4x4 GetInput()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601DB05 RID: 121605
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMatrixToHomogeneousTransform_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Get the MTime: this is the bit of magic that makes everything work.
		/// </summary>
		// Token: 0x0601DB06 RID: 121606 RVA: 0x0029ED18 File Offset: 0x0029CF18
		public override ulong GetMTime()
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601DB07 RID: 121607
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixToHomogeneousTransform_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB08 RID: 121608 RVA: 0x0029ED38 File Offset: 0x0029CF38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601DB09 RID: 121609
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatrixToHomogeneousTransform_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB0A RID: 121610 RVA: 0x0029ED58 File Offset: 0x0029CF58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601DB0B RID: 121611
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixToHomogeneousTransform_Inverse_05(HandleRef pThis);

		/// <summary>
		/// The input matrix is left as-is, but the transformation matrix
		/// is inverted.
		/// </summary>
		// Token: 0x0601DB0C RID: 121612 RVA: 0x0029ED72 File Offset: 0x0029CF72
		public override void Inverse()
		{
			vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_Inverse_05(base.GetCppThis());
		}

		// Token: 0x0601DB0D RID: 121613
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixToHomogeneousTransform_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB0E RID: 121614 RVA: 0x0029ED84 File Offset: 0x0029CF84
		public override int IsA(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601DB0F RID: 121615
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatrixToHomogeneousTransform_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB10 RID: 121616 RVA: 0x0029EDA4 File Offset: 0x0029CFA4
		public new static int IsTypeOf(string type)
		{
			return vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_IsTypeOf_07(type);
		}

		// Token: 0x0601DB11 RID: 121617
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_MakeTransform_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make a new transform of the same type.
		/// </summary>
		// Token: 0x0601DB12 RID: 121618 RVA: 0x0029EDC0 File Offset: 0x0029CFC0
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_MakeTransform_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB13 RID: 121619
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB14 RID: 121620 RVA: 0x0029EE1C File Offset: 0x0029D01C
		public new vtkMatrixToHomogeneousTransform NewInstance()
		{
			vtkMatrixToHomogeneousTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601DB15 RID: 121621
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatrixToHomogeneousTransform_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB16 RID: 121622 RVA: 0x0029EE78 File Offset: 0x0029D078
		public new static vtkMatrixToHomogeneousTransform SafeDownCast(vtkObjectBase o)
		{
			vtkMatrixToHomogeneousTransform vtkMatrixToHomogeneousTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrixToHomogeneousTransform = (vtkMatrixToHomogeneousTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrixToHomogeneousTransform.Register(null);
				}
			}
			return vtkMatrixToHomogeneousTransform;
		}

		// Token: 0x0601DB17 RID: 121623
		[DllImport("Kitware.VTK.CommonTransforms.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatrixToHomogeneousTransform_SetInput_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601DB18 RID: 121624 RVA: 0x0029EEF8 File Offset: 0x0029D0F8
		public virtual void SetInput(vtkMatrix4x4 arg0)
		{
			vtkMatrixToHomogeneousTransform.vtkMatrixToHomogeneousTransform_SetInput_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F45 RID: 8005
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatrixToHomogeneousTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F46 RID: 8006
		public new static readonly string MRClassNameKey = "class vtkMatrixToHomogeneousTransform";
	}
}
