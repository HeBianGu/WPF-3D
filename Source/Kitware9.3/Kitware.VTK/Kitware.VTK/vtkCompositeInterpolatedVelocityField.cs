using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    An abstract class for
	///  obtaining the interpolated velocity values at a point
	///
	///  vtkCompositeInterpolatedVelocityField acts as a continuous velocity field
	///  by performing cell interpolation on one or more underlying vtkDataSets. That is,
	///  composite datasets are combined to create a continuous velocity field. The default
	///  strategy is to use the closest point strategy.
	///
	/// @warning
	///  vtkCompositeInterpolatedVelocityField is not thread safe. A new instance
	///  should be created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkAbstractInterpolatedVelocityField vtkAMRInterpolatedVelocityField
	///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
	///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
	/// </seealso>
	// Token: 0x020004AA RID: 1194
	public class vtkCompositeInterpolatedVelocityField : vtkAbstractInterpolatedVelocityField
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DB9C RID: 56220 RVA: 0x00130A8D File Offset: 0x0012EC8D
		static vtkCompositeInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB9D RID: 56221 RVA: 0x00130AB5 File Offset: 0x0012ECB5
		public vtkCompositeInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DB9E RID: 56222
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField class.
		/// </summary>
		// Token: 0x0600DB9F RID: 56223 RVA: 0x00130AC4 File Offset: 0x0012ECC4
		public new static vtkCompositeInterpolatedVelocityField New()
		{
			vtkCompositeInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField class.
		/// </summary>
		// Token: 0x0600DBA0 RID: 56224 RVA: 0x00130B18 File Offset: 0x0012ED18
		public vtkCompositeInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DBA1 RID: 56225 RVA: 0x00130B5C File Offset: 0x0012ED5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DBA2 RID: 56226
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeInterpolatedVelocityField_AddDataSet_01(HandleRef pThis, HandleRef dataset, ulong maxCellSize);

		/// <summary>
		/// Add a dataset for implicit velocity function evaluation. If more than
		/// one dataset is added, the evaluation point is searched in all until a
		/// match is found. THIS FUNCTION DOES NOT CHANGE THE REFERENCE COUNT OF
		/// dataset FOR THREAD SAFETY REASONS. MaxCellSize can be passed to avoid
		/// recomputing GetMaxCellSize().
		/// </summary>
		// Token: 0x0600DBA3 RID: 56227 RVA: 0x00130B68 File Offset: 0x0012ED68
		public virtual void AddDataSet(vtkDataSet dataset, ulong maxCellSize)
		{
			vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_AddDataSet_01(base.GetCppThis(), (dataset == null) ? default(HandleRef) : dataset.GetCppThis(), maxCellSize);
		}

		// Token: 0x0600DBA4 RID: 56228
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeInterpolatedVelocityField_CopyParameters_02(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. See
		/// vtkAbstractInterpolatedVelocityField for more information.
		/// </summary>
		// Token: 0x0600DBA5 RID: 56229 RVA: 0x00130B98 File Offset: 0x0012ED98
		public override void CopyParameters(vtkAbstractInterpolatedVelocityField from)
		{
			vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_CopyParameters_02(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0600DBA6 RID: 56230
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_FunctionValues_03(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate the velocity field f at point (x, y, z).
		/// </summary>
		// Token: 0x0600DBA7 RID: 56231 RVA: 0x00130BC8 File Offset: 0x0012EDC8
		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_FunctionValues_03(base.GetCppThis(), x, f);
		}

		// Token: 0x0600DBA8 RID: 56232
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_GetCacheDataSetHit_04(HandleRef pThis);

		/// <summary>
		/// Get Cache DataSet hits and misses.
		/// </summary>
		// Token: 0x0600DBA9 RID: 56233 RVA: 0x00130BEC File Offset: 0x0012EDEC
		public virtual int GetCacheDataSetHit()
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_GetCacheDataSetHit_04(base.GetCppThis());
		}

		// Token: 0x0600DBAA RID: 56234
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_GetCacheDataSetMiss_05(HandleRef pThis);

		/// <summary>
		/// Get Cache DataSet hits and misses.
		/// </summary>
		// Token: 0x0600DBAB RID: 56235 RVA: 0x00130C0C File Offset: 0x0012EE0C
		public virtual int GetCacheDataSetMiss()
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_GetCacheDataSetMiss_05(base.GetCppThis());
		}

		// Token: 0x0600DBAC RID: 56236
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_GetLastDataSetIndex_06(HandleRef pThis);

		/// <summary>
		/// Get the most recently visited dataset and its id. The dataset is used
		/// for a guess regarding where the next point will be, without searching
		/// through all datasets. When setting the last dataset, care is needed as
		/// no reference counting or checks are performed. This feature is intended
		/// for custom interpolators only that cache datasets independently.
		/// </summary>
		// Token: 0x0600DBAD RID: 56237 RVA: 0x00130C2C File Offset: 0x0012EE2C
		public virtual int GetLastDataSetIndex()
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_GetLastDataSetIndex_06(base.GetCppThis());
		}

		// Token: 0x0600DBAE RID: 56238
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBAF RID: 56239 RVA: 0x00130C4C File Offset: 0x0012EE4C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600DBB0 RID: 56240
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBB1 RID: 56241 RVA: 0x00130C6C File Offset: 0x0012EE6C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600DBB2 RID: 56242
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_InsideTest_09(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Check if point x is inside the dataset.
		/// </summary>
		// Token: 0x0600DBB3 RID: 56243 RVA: 0x00130C88 File Offset: 0x0012EE88
		public int InsideTest(IntPtr x)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_InsideTest_09(base.GetCppThis(), x);
		}

		// Token: 0x0600DBB4 RID: 56244
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBB5 RID: 56245 RVA: 0x00130CA8 File Offset: 0x0012EEA8
		public override int IsA(string type)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600DBB6 RID: 56246
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBB7 RID: 56247 RVA: 0x00130CC8 File Offset: 0x0012EEC8
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_IsTypeOf_11(type);
		}

		// Token: 0x0600DBB8 RID: 56248
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeInterpolatedVelocityField_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBB9 RID: 56249 RVA: 0x00130CE4 File Offset: 0x0012EEE4
		public new vtkCompositeInterpolatedVelocityField NewInstance()
		{
			vtkCompositeInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DBBA RID: 56250
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeInterpolatedVelocityField_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBBB RID: 56251 RVA: 0x00130D40 File Offset: 0x0012EF40
		public new static vtkCompositeInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeInterpolatedVelocityField vtkCompositeInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeInterpolatedVelocityField = (vtkCompositeInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeInterpolatedVelocityField.Register(null);
				}
			}
			return vtkCompositeInterpolatedVelocityField;
		}

		// Token: 0x0600DBBC RID: 56252
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeInterpolatedVelocityField_SetLastCellId_15(HandleRef pThis, long c, int dataindex);

		/// <summary>
		/// Set the cell id cached by the last evaluation within a specified dataset.
		/// </summary>
		// Token: 0x0600DBBD RID: 56253 RVA: 0x00130DBF File Offset: 0x0012EFBF
		public override void SetLastCellId(long c, int dataindex)
		{
			vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_SetLastCellId_15(base.GetCppThis(), c, dataindex);
		}

		// Token: 0x0600DBBE RID: 56254
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeInterpolatedVelocityField_SetLastCellId_16(HandleRef pThis, long c);

		/// <summary>
		/// Set the cell id cached by the last evaluation.
		/// </summary>
		// Token: 0x0600DBBF RID: 56255 RVA: 0x00130DD0 File Offset: 0x0012EFD0
		public override void SetLastCellId(long c)
		{
			vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_SetLastCellId_16(base.GetCppThis(), c);
		}

		// Token: 0x0600DBC0 RID: 56256
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeInterpolatedVelocityField_SnapPointOnCell_17(HandleRef pThis, IntPtr pOrigin, IntPtr pProj);

		/// <summary>
		/// Project the provided point on current cell, current dataset.
		/// </summary>
		// Token: 0x0600DBC1 RID: 56257 RVA: 0x00130DE0 File Offset: 0x0012EFE0
		public virtual int SnapPointOnCell(IntPtr pOrigin, IntPtr pProj)
		{
			return vtkCompositeInterpolatedVelocityField.vtkCompositeInterpolatedVelocityField_SnapPointOnCell_17(base.GetCppThis(), pOrigin, pProj);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100B RID: 4107
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100C RID: 4108
		public new static readonly string MRClassNameKey = "class vtkCompositeInterpolatedVelocityField";
	}
}
