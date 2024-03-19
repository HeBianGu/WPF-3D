using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtentSplitter
	/// </summary>
	/// <remarks>
	///    Split an extent across other extents.
	///
	/// vtkExtentSplitter splits each input extent into non-overlapping
	/// sub-extents that are completely contained within other "source
	/// extents".  A source extent corresponds to some resource providing
	/// an extent.  Each source extent has an integer identifier, integer
	/// priority, and an extent.  The input extents are split into
	/// sub-extents according to priority, availability, and amount of
	/// overlap of the source extents.  This can be used by parallel data
	/// readers to read as few piece files as possible.
	/// </remarks>
	// Token: 0x020009CF RID: 2511
	public class vtkExtentSplitter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A30D RID: 107277 RVA: 0x00244FDB File Offset: 0x002431DB
		static vtkExtentSplitter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtentSplitter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentSplitter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A30E RID: 107278 RVA: 0x00245003 File Offset: 0x00243203
		public vtkExtentSplitter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A30F RID: 107279
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentSplitter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A310 RID: 107280 RVA: 0x00245014 File Offset: 0x00243214
		public new static vtkExtentSplitter New()
		{
			vtkExtentSplitter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A311 RID: 107281 RVA: 0x00245068 File Offset: 0x00243268
		public vtkExtentSplitter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtentSplitter.vtkExtentSplitter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A312 RID: 107282 RVA: 0x002450AC File Offset: 0x002432AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A313 RID: 107283
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_AddExtent_01(HandleRef pThis, int x0, int x1, int y0, int y1, int z0, int z1);

		/// <summary>
		/// Add an extent to the queue of extents to be split among the
		/// available sources.
		/// </summary>
		// Token: 0x0601A314 RID: 107284 RVA: 0x002450B7 File Offset: 0x002432B7
		public void AddExtent(int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtent_01(base.GetCppThis(), x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601A315 RID: 107285
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_AddExtent_02(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Add an extent to the queue of extents to be split among the
		/// available sources.
		/// </summary>
		// Token: 0x0601A316 RID: 107286 RVA: 0x002450CF File Offset: 0x002432CF
		public void AddExtent(IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtent_02(base.GetCppThis(), extent);
		}

		// Token: 0x0601A317 RID: 107287
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_AddExtentSource_03(HandleRef pThis, int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1);

		/// <summary>
		/// Add/Remove a source providing the given extent.  Sources with
		/// higher priority numbers are favored.  Source id numbers and
		/// priorities must be non-negative.
		/// </summary>
		// Token: 0x0601A318 RID: 107288 RVA: 0x002450E0 File Offset: 0x002432E0
		public void AddExtentSource(int id, int priority, int x0, int x1, int y0, int y1, int z0, int z1)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtentSource_03(base.GetCppThis(), id, priority, x0, x1, y0, y1, z0, z1);
		}

		// Token: 0x0601A319 RID: 107289
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_AddExtentSource_04(HandleRef pThis, int id, int priority, IntPtr extent);

		/// <summary>
		/// Add/Remove a source providing the given extent.  Sources with
		/// higher priority numbers are favored.  Source id numbers and
		/// priorities must be non-negative.
		/// </summary>
		// Token: 0x0601A31A RID: 107290 RVA: 0x00245107 File Offset: 0x00243307
		public void AddExtentSource(int id, int priority, IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_AddExtentSource_04(base.GetCppThis(), id, priority, extent);
		}

		// Token: 0x0601A31B RID: 107291
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_ComputeSubExtents_05(HandleRef pThis);

		/// <summary>
		/// Split the extents currently in the queue among the available
		/// sources.  The queue is empty when this returns.  Returns 1 if all
		/// extents could be read.  Returns 0 if any portion of any extent
		/// was not available through any source.
		/// </summary>
		// Token: 0x0601A31C RID: 107292 RVA: 0x0024511C File Offset: 0x0024331C
		public int ComputeSubExtents()
		{
			return vtkExtentSplitter.vtkExtentSplitter_ComputeSubExtents_05(base.GetCppThis());
		}

		// Token: 0x0601A31D RID: 107293
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentSplitter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A31E RID: 107294 RVA: 0x0024513C File Offset: 0x0024333C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601A31F RID: 107295
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentSplitter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A320 RID: 107296 RVA: 0x0024515C File Offset: 0x0024335C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601A321 RID: 107297
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_GetNumberOfSubExtents_08(HandleRef pThis);

		/// <summary>
		/// Get the number of sub-extents into which the original set of
		/// extents have been split across the available sources.  Valid
		/// after a call to ComputeSubExtents.
		/// </summary>
		// Token: 0x0601A322 RID: 107298 RVA: 0x00245178 File Offset: 0x00243378
		public int GetNumberOfSubExtents()
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetNumberOfSubExtents_08(base.GetCppThis());
		}

		// Token: 0x0601A323 RID: 107299
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_GetPointMode_09(HandleRef pThis);

		/// <summary>
		/// Get/Set whether "point mode" is on.  In point mode, sub-extents
		/// are generated to ensure every point in the update request is
		/// read, but not necessarily every cell.  This can be used when
		/// point data are stored in a planar slice per piece with no cell
		/// data.  The default is OFF.
		/// </summary>
		// Token: 0x0601A324 RID: 107300 RVA: 0x00245198 File Offset: 0x00243398
		public virtual int GetPointMode()
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetPointMode_09(base.GetCppThis());
		}

		// Token: 0x0601A325 RID: 107301
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentSplitter_GetSubExtent_10(HandleRef pThis, int index);

		/// <summary>
		/// Get the sub-extent associated with the given index.  Use
		/// GetSubExtentSource to get the id of the source from which this
		/// sub-extent should be read.  Valid after a call to
		/// ComputeSubExtents.
		/// </summary>
		// Token: 0x0601A326 RID: 107302 RVA: 0x002451B8 File Offset: 0x002433B8
		public int[] GetSubExtent(int index)
		{
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_GetSubExtent_10(base.GetCppThis(), index);
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A327 RID: 107303
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_GetSubExtent_11(HandleRef pThis, int index, IntPtr extent);

		/// <summary>
		/// Get the sub-extent associated with the given index.  Use
		/// GetSubExtentSource to get the id of the source from which this
		/// sub-extent should be read.  Valid after a call to
		/// ComputeSubExtents.
		/// </summary>
		// Token: 0x0601A328 RID: 107304 RVA: 0x00245201 File Offset: 0x00243401
		public void GetSubExtent(int index, IntPtr extent)
		{
			vtkExtentSplitter.vtkExtentSplitter_GetSubExtent_11(base.GetCppThis(), index, extent);
		}

		// Token: 0x0601A329 RID: 107305
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_GetSubExtentSource_12(HandleRef pThis, int index);

		/// <summary>
		/// Get the id of the source from which the sub-extent associated
		/// with the given index should be read.  Returns -1 if no source
		/// provides the sub-extent.
		/// </summary>
		// Token: 0x0601A32A RID: 107306 RVA: 0x00245214 File Offset: 0x00243414
		public int GetSubExtentSource(int index)
		{
			return vtkExtentSplitter.vtkExtentSplitter_GetSubExtentSource_12(base.GetCppThis(), index);
		}

		// Token: 0x0601A32B RID: 107307
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A32C RID: 107308 RVA: 0x00245234 File Offset: 0x00243434
		public override int IsA(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x0601A32D RID: 107309
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentSplitter_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A32E RID: 107310 RVA: 0x00245254 File Offset: 0x00243454
		public new static int IsTypeOf(string type)
		{
			return vtkExtentSplitter.vtkExtentSplitter_IsTypeOf_14(type);
		}

		// Token: 0x0601A32F RID: 107311
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentSplitter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A330 RID: 107312 RVA: 0x00245270 File Offset: 0x00243470
		public new vtkExtentSplitter NewInstance()
		{
			vtkExtentSplitter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A331 RID: 107313
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_PointModeOff_17(HandleRef pThis);

		/// <summary>
		/// Get/Set whether "point mode" is on.  In point mode, sub-extents
		/// are generated to ensure every point in the update request is
		/// read, but not necessarily every cell.  This can be used when
		/// point data are stored in a planar slice per piece with no cell
		/// data.  The default is OFF.
		/// </summary>
		// Token: 0x0601A332 RID: 107314 RVA: 0x002452CA File Offset: 0x002434CA
		public virtual void PointModeOff()
		{
			vtkExtentSplitter.vtkExtentSplitter_PointModeOff_17(base.GetCppThis());
		}

		// Token: 0x0601A333 RID: 107315
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_PointModeOn_18(HandleRef pThis);

		/// <summary>
		/// Get/Set whether "point mode" is on.  In point mode, sub-extents
		/// are generated to ensure every point in the update request is
		/// read, but not necessarily every cell.  This can be used when
		/// point data are stored in a planar slice per piece with no cell
		/// data.  The default is OFF.
		/// </summary>
		// Token: 0x0601A334 RID: 107316 RVA: 0x002452D9 File Offset: 0x002434D9
		public virtual void PointModeOn()
		{
			vtkExtentSplitter.vtkExtentSplitter_PointModeOn_18(base.GetCppThis());
		}

		// Token: 0x0601A335 RID: 107317
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_RemoveAllExtentSources_19(HandleRef pThis);

		/// <summary>
		/// Add/Remove a source providing the given extent.  Sources with
		/// higher priority numbers are favored.  Source id numbers and
		/// priorities must be non-negative.
		/// </summary>
		// Token: 0x0601A336 RID: 107318 RVA: 0x002452E8 File Offset: 0x002434E8
		public void RemoveAllExtentSources()
		{
			vtkExtentSplitter.vtkExtentSplitter_RemoveAllExtentSources_19(base.GetCppThis());
		}

		// Token: 0x0601A337 RID: 107319
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_RemoveExtentSource_20(HandleRef pThis, int id);

		/// <summary>
		/// Add/Remove a source providing the given extent.  Sources with
		/// higher priority numbers are favored.  Source id numbers and
		/// priorities must be non-negative.
		/// </summary>
		// Token: 0x0601A338 RID: 107320 RVA: 0x002452F7 File Offset: 0x002434F7
		public void RemoveExtentSource(int id)
		{
			vtkExtentSplitter.vtkExtentSplitter_RemoveExtentSource_20(base.GetCppThis(), id);
		}

		// Token: 0x0601A339 RID: 107321
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentSplitter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A33A RID: 107322 RVA: 0x00245308 File Offset: 0x00243508
		public new static vtkExtentSplitter SafeDownCast(vtkObjectBase o)
		{
			vtkExtentSplitter vtkExtentSplitter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentSplitter.vtkExtentSplitter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentSplitter = (vtkExtentSplitter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentSplitter.Register(null);
				}
			}
			return vtkExtentSplitter;
		}

		// Token: 0x0601A33B RID: 107323
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentSplitter_SetPointMode_22(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set whether "point mode" is on.  In point mode, sub-extents
		/// are generated to ensure every point in the update request is
		/// read, but not necessarily every cell.  This can be used when
		/// point data are stored in a planar slice per piece with no cell
		/// data.  The default is OFF.
		/// </summary>
		// Token: 0x0601A33C RID: 107324 RVA: 0x00245387 File Offset: 0x00243587
		public virtual void SetPointMode(int _arg)
		{
			vtkExtentSplitter.vtkExtentSplitter_SetPointMode_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C6B RID: 7275
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtentSplitter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C6C RID: 7276
		public new static readonly string MRClassNameKey = "class vtkExtentSplitter";
	}
}
