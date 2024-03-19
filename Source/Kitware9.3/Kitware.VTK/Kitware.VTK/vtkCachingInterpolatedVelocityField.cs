using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCachingInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    Interface for obtaining
	/// interpolated velocity values
	///
	/// vtkCachingInterpolatedVelocityField acts as a continuous velocity field
	/// by performing cell interpolation on the underlying vtkDataSet.
	/// This is a concrete sub-class of vtkFunctionSet with
	/// NumberOfIndependentVariables = 4 (x,y,z,t) and
	/// NumberOfFunctions = 3 (u,v,w). Normally, every time an evaluation
	/// is performed, the cell which contains the point (x,y,z) has to
	/// be found by calling FindCell. This is a computationally expensive
	/// operation. In certain cases, the cell search can be avoided or shortened
	/// by providing a guess for the cell id. For example, in streamline
	/// integration, the next evaluation is usually in the same or a neighbour
	/// cell. For this reason, vtkCachingInterpolatedVelocityField stores the last
	/// cell id. If caching is turned on, it uses this id as the starting point.
	///
	/// @warning
	/// vtkCachingInterpolatedVelocityField is not thread safe. A new instance should
	/// be created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFunctionSet vtkStreamTracer
	///
	/// @todo
	/// Need to clean up style to match vtk/Kitware standards. Please help.
	/// </seealso>
	// Token: 0x020004A9 RID: 1193
	public class vtkCachingInterpolatedVelocityField : vtkFunctionSet
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DB72 RID: 56178 RVA: 0x001306BC File Offset: 0x0012E8BC
		static vtkCachingInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCachingInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCachingInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB73 RID: 56179 RVA: 0x001306E4 File Offset: 0x0012E8E4
		public vtkCachingInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DB74 RID: 56180
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkCachingInterpolatedVelocityField with no initial data set.
		/// LastCellId is set to -1.
		/// </summary>
		// Token: 0x0600DB75 RID: 56181 RVA: 0x001306F4 File Offset: 0x0012E8F4
		public new static vtkCachingInterpolatedVelocityField New()
		{
			vtkCachingInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkCachingInterpolatedVelocityField with no initial data set.
		/// LastCellId is set to -1.
		/// </summary>
		// Token: 0x0600DB76 RID: 56182 RVA: 0x00130748 File Offset: 0x0012E948
		public vtkCachingInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DB77 RID: 56183 RVA: 0x0013078C File Offset: 0x0012E98C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DB78 RID: 56184
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(HandleRef pThis);

		/// <summary>
		/// Set LastCellId to -1 and Cache to nullptr so that the next
		/// search does not start from the previous cell.
		/// </summary>
		// Token: 0x0600DB79 RID: 56185 RVA: 0x00130797 File Offset: 0x0012E997
		public void ClearLastCellInfo()
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_ClearLastCellInfo_01(base.GetCppThis());
		}

		// Token: 0x0600DB7A RID: 56186
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_FunctionValues_02(HandleRef pThis, IntPtr x, IntPtr f);

		/// <summary>
		/// Evaluate the velocity field, f={u,v,w}, at {x, y, z}.
		/// returns 1 if valid, 0 if test failed
		/// </summary>
		// Token: 0x0600DB7B RID: 56187 RVA: 0x001307A8 File Offset: 0x0012E9A8
		public override int FunctionValues(IntPtr x, IntPtr f)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_FunctionValues_02(base.GetCppThis(), x, f);
		}

		// Token: 0x0600DB7C RID: 56188
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_GetCacheMiss_03(HandleRef pThis);

		/// <summary>
		/// Caching statistics.
		/// </summary>
		// Token: 0x0600DB7D RID: 56189 RVA: 0x001307CC File Offset: 0x0012E9CC
		public virtual int GetCacheMiss()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetCacheMiss_03(base.GetCppThis());
		}

		// Token: 0x0600DB7E RID: 56190
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(HandleRef pThis);

		/// <summary>
		/// Caching statistics.
		/// </summary>
		// Token: 0x0600DB7F RID: 56191 RVA: 0x001307EC File Offset: 0x0012E9EC
		public virtual int GetCellCacheHit()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetCellCacheHit_04(base.GetCppThis());
		}

		// Token: 0x0600DB80 RID: 56192
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(HandleRef pThis);

		/// <summary>
		/// Caching statistics.
		/// </summary>
		// Token: 0x0600DB81 RID: 56193 RVA: 0x0013080C File Offset: 0x0012EA0C
		public virtual int GetDataSetCacheHit()
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetDataSetCacheHit_05(base.GetCppThis());
		}

		// Token: 0x0600DB82 RID: 56194
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(HandleRef pThis, IntPtr pcoords);

		/// <summary>
		/// Returns the interpolation weights/pcoords cached from last evaluation
		/// if the cached cell is valid (returns 1). Otherwise, it does not
		/// change w and returns 0.
		/// </summary>
		// Token: 0x0600DB83 RID: 56195 RVA: 0x0013082C File Offset: 0x0012EA2C
		public int GetLastLocalCoordinates(IntPtr pcoords)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetLastLocalCoordinates_06(base.GetCppThis(), pcoords);
		}

		// Token: 0x0600DB84 RID: 56196
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_GetLastWeights_07(HandleRef pThis, IntPtr w);

		/// <summary>
		/// Returns the interpolation weights/pcoords cached from last evaluation
		/// if the cached cell is valid (returns 1). Otherwise, it does not
		/// change w and returns 0.
		/// </summary>
		// Token: 0x0600DB85 RID: 56197 RVA: 0x0013084C File Offset: 0x0012EA4C
		public int GetLastWeights(IntPtr w)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetLastWeights_07(base.GetCppThis(), w);
		}

		// Token: 0x0600DB86 RID: 56198
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB87 RID: 56199 RVA: 0x0013086C File Offset: 0x0012EA6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600DB88 RID: 56200
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB89 RID: 56201 RVA: 0x0013088C File Offset: 0x0012EA8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600DB8A RID: 56202
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_GetVectorsSelection_10(HandleRef pThis);

		/// <summary>
		/// If you want to work with an arbitrary vector array, then set its name
		/// here. By default this in nullptr and the filter will use the active vector
		/// array.
		/// </summary>
		// Token: 0x0600DB8B RID: 56203 RVA: 0x001308A8 File Offset: 0x0012EAA8
		public virtual string GetVectorsSelection()
		{
			string s = Marshal.PtrToStringAnsi(vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_GetVectorsSelection_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600DB8C RID: 56204
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_InsideTest_11(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Evaluate the velocity field, f={u,v,w}, at {x, y, z}.
		/// returns 1 if valid, 0 if test failed
		/// </summary>
		// Token: 0x0600DB8D RID: 56205 RVA: 0x001308E4 File Offset: 0x0012EAE4
		public virtual int InsideTest(IntPtr x)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_InsideTest_11(base.GetCppThis(), x);
		}

		// Token: 0x0600DB8E RID: 56206
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB8F RID: 56207 RVA: 0x00130904 File Offset: 0x0012EB04
		public override int IsA(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0600DB90 RID: 56208
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCachingInterpolatedVelocityField_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB91 RID: 56209 RVA: 0x00130924 File Offset: 0x0012EB24
		public new static int IsTypeOf(string type)
		{
			return vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_IsTypeOf_13(type);
		}

		// Token: 0x0600DB92 RID: 56210
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB93 RID: 56211 RVA: 0x00130940 File Offset: 0x0012EB40
		public new vtkCachingInterpolatedVelocityField NewInstance()
		{
			vtkCachingInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DB94 RID: 56212
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCachingInterpolatedVelocityField_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DB95 RID: 56213 RVA: 0x0013099C File Offset: 0x0012EB9C
		public new static vtkCachingInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkCachingInterpolatedVelocityField vtkCachingInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCachingInterpolatedVelocityField = (vtkCachingInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCachingInterpolatedVelocityField.Register(null);
				}
			}
			return vtkCachingInterpolatedVelocityField;
		}

		// Token: 0x0600DB96 RID: 56214
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCachingInterpolatedVelocityField_SelectVectors_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string fieldName);

		/// <summary>
		/// If you want to work with an arbitrary vector array, then set its name
		/// here. By default this in nullptr and the filter will use the active vector
		/// array.
		/// </summary>
		// Token: 0x0600DB97 RID: 56215 RVA: 0x00130A1B File Offset: 0x0012EC1B
		public void SelectVectors(string fieldName)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SelectVectors_17(base.GetCppThis(), fieldName);
		}

		// Token: 0x0600DB98 RID: 56216
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCachingInterpolatedVelocityField_SetDataSet_18(HandleRef pThis, int I, HandleRef dataset, byte staticdataset, HandleRef locator);

		/// <summary>
		/// Add a dataset used by the interpolation function evaluation.
		/// </summary>
		// Token: 0x0600DB99 RID: 56217 RVA: 0x00130A2C File Offset: 0x0012EC2C
		public virtual void SetDataSet(int I, vtkDataSet dataset, bool staticdataset, vtkAbstractCellLocator locator)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SetDataSet_18(base.GetCppThis(), I, (dataset == null) ? default(HandleRef) : dataset.GetCppThis(), staticdataset ? (byte)1 : (byte)0, (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600DB9A RID: 56218
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCachingInterpolatedVelocityField_SetLastCellInfo_19(HandleRef pThis, long c, int datasetindex);

		/// <summary>
		/// Set LastCellId to c and LastCacheIndex datasetindex, cached from last evaluation.
		/// If c isn't -1 then the corresponding cell is stored in Cache-&gt;Cell.
		/// These values should be valid or an assertion will be triggered.
		/// </summary>
		// Token: 0x0600DB9B RID: 56219 RVA: 0x00130A7C File Offset: 0x0012EC7C
		public void SetLastCellInfo(long c, int datasetindex)
		{
			vtkCachingInterpolatedVelocityField.vtkCachingInterpolatedVelocityField_SetLastCellInfo_19(base.GetCppThis(), c, datasetindex);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001009 RID: 4105
		public new const string MRFullTypeName = "Kitware.VTK.vtkCachingInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100A RID: 4106
		public new static readonly string MRClassNameKey = "class vtkCachingInterpolatedVelocityField";
	}
}
