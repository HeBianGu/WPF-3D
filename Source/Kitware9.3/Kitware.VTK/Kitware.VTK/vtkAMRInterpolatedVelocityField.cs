using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAMRInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    A concrete class for obtaining
	///  the interpolated velocity values at a point in AMR data.
	///
	/// The main functionality supported here is the point location inside
	/// vtkOverlappingAMR data set.
	/// </remarks>
	// Token: 0x020004A8 RID: 1192
	public class vtkAMRInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DB4C RID: 56140 RVA: 0x001302C0 File Offset: 0x0012E4C0
		static vtkAMRInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAMRInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB4D RID: 56141 RVA: 0x001302E8 File Offset: 0x0012E4E8
		public vtkAMRInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DB4E RID: 56142
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB4F RID: 56143 RVA: 0x001302F8 File Offset: 0x0012E4F8
		public new static vtkAMRInterpolatedVelocityField New()
		{
			vtkAMRInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB50 RID: 56144 RVA: 0x0013034C File Offset: 0x0012E54C
		public vtkAMRInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB51 RID: 56145 RVA: 0x00130390 File Offset: 0x0012E590
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DB52 RID: 56146
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInterpolatedVelocityField_CopyParameters_01(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// interpolators between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0600DB53 RID: 56147 RVA: 0x0013039C File Offset: 0x0012E59C
		public override void CopyParameters(vtkAbstractInterpolatedVelocityField from)
		{
			vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_CopyParameters_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0600DB54 RID: 56148
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInterpolatedVelocityField_FindGrid_02(IntPtr q, HandleRef amrds, ref uint level, ref uint gridId);

		/// <summary>
		/// Helper function to locator the grid within an AMR dataset.
		/// </summary>
		// Token: 0x0600DB55 RID: 56149 RVA: 0x001303CC File Offset: 0x0012E5CC
		public static bool FindGrid(IntPtr q, vtkOverlappingAMR amrds, ref uint level, ref uint gridId)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_FindGrid_02(q, (amrds == null) ? default(HandleRef) : amrds.GetCppThis(), ref level, ref gridId) != 0;
		}

		// Token: 0x0600DB56 RID: 56150
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate the velocity field f at point p.
		/// If it succeeds, then both the last data set (this-&gt;LastDataSet) and
		/// the last data set location (this-&gt;LastLevel, this-&gt;LastId) will be
		/// set according to where p is found.  If it fails, either p is out of
		/// bound, in which case both the last data set and the last location
		/// will be invalid or, in a multi-process setting, p is inbound but not
		/// on the processor.  In the last case, the last data set location is
		/// still valid
		/// </summary>
		// Token: 0x0600DB57 RID: 56151 RVA: 0x00130404 File Offset: 0x0012E604
		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_FunctionValues_03(base.GetCppThis(), x, f);
		}

		// Token: 0x0600DB58 RID: 56152
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInterpolatedVelocityField_GetAmrDataSet_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///
		/// Specify the AMR dataset to process.
		/// </summary>
		// Token: 0x0600DB59 RID: 56153 RVA: 0x00130428 File Offset: 0x0012E628
		public virtual vtkOverlappingAMR GetAmrDataSet()
		{
			vtkOverlappingAMR vtkOverlappingAMR = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_GetAmrDataSet_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMR = (vtkOverlappingAMR)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMR.Register(null);
				}
			}
			return vtkOverlappingAMR;
		}

		// Token: 0x0600DB5A RID: 56154
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInterpolatedVelocityField_GetLastDataSetLocation_05(HandleRef pThis, ref uint level, ref uint id);

		/// <summary>
		/// Methods to support local caching while searching for AMR datasets.
		/// </summary>
		// Token: 0x0600DB5B RID: 56155 RVA: 0x00130498 File Offset: 0x0012E698
		public bool GetLastDataSetLocation(ref uint level, ref uint id)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_GetLastDataSetLocation_05(base.GetCppThis(), ref level, ref id) != 0;
		}

		// Token: 0x0600DB5C RID: 56156
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB5D RID: 56157 RVA: 0x001304C0 File Offset: 0x0012E6C0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600DB5E RID: 56158
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB5F RID: 56159 RVA: 0x001304E0 File Offset: 0x0012E6E0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600DB60 RID: 56160
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInterpolatedVelocityField_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB61 RID: 56161 RVA: 0x001304FC File Offset: 0x0012E6FC
		public override int IsA(string type)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600DB62 RID: 56162
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAMRInterpolatedVelocityField_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB63 RID: 56163 RVA: 0x0013051C File Offset: 0x0012E71C
		public new static int IsTypeOf(string type)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_IsTypeOf_09(type);
		}

		// Token: 0x0600DB64 RID: 56164
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInterpolatedVelocityField_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB65 RID: 56165 RVA: 0x00130538 File Offset: 0x0012E738
		public new vtkAMRInterpolatedVelocityField NewInstance()
		{
			vtkAMRInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DB66 RID: 56166
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAMRInterpolatedVelocityField_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information and printing the object state.
		/// </summary>
		// Token: 0x0600DB67 RID: 56167 RVA: 0x00130594 File Offset: 0x0012E794
		public new static vtkAMRInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkAMRInterpolatedVelocityField vtkAMRInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAMRInterpolatedVelocityField = (vtkAMRInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAMRInterpolatedVelocityField.Register(null);
				}
			}
			return vtkAMRInterpolatedVelocityField;
		}

		// Token: 0x0600DB68 RID: 56168
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInterpolatedVelocityField_SetAMRData_13(HandleRef pThis, HandleRef amr);

		/// <summary>
		///
		/// Specify the AMR dataset to process.
		/// </summary>
		// Token: 0x0600DB69 RID: 56169 RVA: 0x00130614 File Offset: 0x0012E814
		public void SetAMRData(vtkOverlappingAMR amr)
		{
			vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SetAMRData_13(base.GetCppThis(), (amr == null) ? default(HandleRef) : amr.GetCppThis());
		}

		// Token: 0x0600DB6A RID: 56170
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInterpolatedVelocityField_SetAmrDataSet_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///
		/// Specify the AMR dataset to process.
		/// </summary>
		// Token: 0x0600DB6B RID: 56171 RVA: 0x00130644 File Offset: 0x0012E844
		public virtual void SetAmrDataSet(vtkOverlappingAMR arg0)
		{
			vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SetAmrDataSet_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600DB6C RID: 56172
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInterpolatedVelocityField_SetLastCellId_15(HandleRef pThis, long c);

		/// <summary>
		/// Set the cell id cached by the last evaluation.
		/// </summary>
		// Token: 0x0600DB6D RID: 56173 RVA: 0x00130673 File Offset: 0x0012E873
		public override void SetLastCellId(long c)
		{
			vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SetLastCellId_15(base.GetCppThis(), c);
		}

		// Token: 0x0600DB6E RID: 56174
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAMRInterpolatedVelocityField_SetLastCellId_16(HandleRef pThis, long c, int dataindex);

		/// <summary>
		/// Methods to support local caching while searching for AMR datasets.
		/// </summary>
		// Token: 0x0600DB6F RID: 56175 RVA: 0x00130683 File Offset: 0x0012E883
		public override void SetLastCellId(long c, int dataindex)
		{
			vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SetLastCellId_16(base.GetCppThis(), c, dataindex);
		}

		// Token: 0x0600DB70 RID: 56176
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAMRInterpolatedVelocityField_SetLastDataSet_17(HandleRef pThis, int level, int id);

		/// <summary>
		/// Methods to support local caching while searching for AMR datasets.
		/// </summary>
		// Token: 0x0600DB71 RID: 56177 RVA: 0x00130694 File Offset: 0x0012E894
		public bool SetLastDataSet(int level, int id)
		{
			return vtkAMRInterpolatedVelocityField.vtkAMRInterpolatedVelocityField_SetLastDataSet_17(base.GetCppThis(), level, id) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001007 RID: 4103
		public new const string MRFullTypeName = "Kitware.VTK.vtkAMRInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001008 RID: 4104
		public new static readonly string MRClassNameKey = "class vtkAMRInterpolatedVelocityField";
	}
}
