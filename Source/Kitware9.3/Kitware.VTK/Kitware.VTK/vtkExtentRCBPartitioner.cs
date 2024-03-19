using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtentRCBPartitioner
	/// </summary>
	/// <remarks>
	///    This method partitions a global extent to N partitions where N is a user
	///  supplied parameter.
	/// </remarks>
	// Token: 0x020009CE RID: 2510
	public class vtkExtentRCBPartitioner : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A2E3 RID: 107235 RVA: 0x00244CB3 File Offset: 0x00242EB3
		static vtkExtentRCBPartitioner()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtentRCBPartitioner.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtentRCBPartitioner"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2E4 RID: 107236 RVA: 0x00244CDB File Offset: 0x00242EDB
		public vtkExtentRCBPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A2E5 RID: 107237
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentRCBPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2E6 RID: 107238 RVA: 0x00244CEC File Offset: 0x00242EEC
		public new static vtkExtentRCBPartitioner New()
		{
			vtkExtentRCBPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2E7 RID: 107239 RVA: 0x00244D40 File Offset: 0x00242F40
		public vtkExtentRCBPartitioner() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2E8 RID: 107240 RVA: 0x00244D84 File Offset: 0x00242F84
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A2E9 RID: 107241
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_DuplicateNodesOff_01(HandleRef pThis);

		/// <summary>
		/// On/Off DuplicateNodes between partitions. Default is On.
		/// </summary>
		// Token: 0x0601A2EA RID: 107242 RVA: 0x00244D8F File Offset: 0x00242F8F
		public virtual void DuplicateNodesOff()
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_DuplicateNodesOff_01(base.GetCppThis());
		}

		// Token: 0x0601A2EB RID: 107243
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_DuplicateNodesOn_02(HandleRef pThis);

		/// <summary>
		/// On/Off DuplicateNodes between partitions. Default is On.
		/// </summary>
		// Token: 0x0601A2EC RID: 107244 RVA: 0x00244D9E File Offset: 0x00242F9E
		public virtual void DuplicateNodesOn()
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_DuplicateNodesOn_02(base.GetCppThis());
		}

		// Token: 0x0601A2ED RID: 107245
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentRCBPartitioner_GetDuplicateNodes_03(HandleRef pThis);

		/// <summary>
		/// On/Off DuplicateNodes between partitions. Default is On.
		/// </summary>
		// Token: 0x0601A2EE RID: 107246 RVA: 0x00244DB0 File Offset: 0x00242FB0
		public virtual int GetDuplicateNodes()
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetDuplicateNodes_03(base.GetCppThis());
		}

		// Token: 0x0601A2EF RID: 107247
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentRCBPartitioner_GetNumExtents_04(HandleRef pThis);

		/// <summary>
		/// Returns the number of extents.
		/// </summary>
		// Token: 0x0601A2F0 RID: 107248 RVA: 0x00244DD0 File Offset: 0x00242FD0
		public virtual int GetNumExtents()
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetNumExtents_04(base.GetCppThis());
		}

		// Token: 0x0601A2F1 RID: 107249
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2F2 RID: 107250 RVA: 0x00244DF0 File Offset: 0x00242FF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A2F3 RID: 107251
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2F4 RID: 107252 RVA: 0x00244E10 File Offset: 0x00243010
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601A2F5 RID: 107253
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentRCBPartitioner_GetNumberOfGhostLayers_07(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A2F6 RID: 107254 RVA: 0x00244E2C File Offset: 0x0024302C
		public virtual int GetNumberOfGhostLayers()
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetNumberOfGhostLayers_07(base.GetCppThis());
		}

		// Token: 0x0601A2F7 RID: 107255
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_GetPartitionExtent_08(HandleRef pThis, int idx, IntPtr ext);

		/// <summary>
		/// Returns the extent of the partition corresponding to the given ID.
		/// </summary>
		// Token: 0x0601A2F8 RID: 107256 RVA: 0x00244E4B File Offset: 0x0024304B
		public void GetPartitionExtent(int idx, IntPtr ext)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_GetPartitionExtent_08(base.GetCppThis(), idx, ext);
		}

		// Token: 0x0601A2F9 RID: 107257
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentRCBPartitioner_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2FA RID: 107258 RVA: 0x00244E5C File Offset: 0x0024305C
		public override int IsA(string type)
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601A2FB RID: 107259
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtentRCBPartitioner_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2FC RID: 107260 RVA: 0x00244E7C File Offset: 0x0024307C
		public new static int IsTypeOf(string type)
		{
			return vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_IsTypeOf_10(type);
		}

		// Token: 0x0601A2FD RID: 107261
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentRCBPartitioner_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2FE RID: 107262 RVA: 0x00244E98 File Offset: 0x00243098
		public new vtkExtentRCBPartitioner NewInstance()
		{
			vtkExtentRCBPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A2FF RID: 107263
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_Partition_13(HandleRef pThis);

		/// <summary>
		/// Partitions the extent
		/// </summary>
		// Token: 0x0601A300 RID: 107264 RVA: 0x00244EF2 File Offset: 0x002430F2
		public void Partition()
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_Partition_13(base.GetCppThis());
		}

		// Token: 0x0601A301 RID: 107265
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtentRCBPartitioner_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A302 RID: 107266 RVA: 0x00244F04 File Offset: 0x00243104
		public new static vtkExtentRCBPartitioner SafeDownCast(vtkObjectBase o)
		{
			vtkExtentRCBPartitioner vtkExtentRCBPartitioner = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentRCBPartitioner = (vtkExtentRCBPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentRCBPartitioner.Register(null);
				}
			}
			return vtkExtentRCBPartitioner;
		}

		// Token: 0x0601A303 RID: 107267
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_SetDuplicateNodes_15(HandleRef pThis, int _arg);

		/// <summary>
		/// On/Off DuplicateNodes between partitions. Default is On.
		/// </summary>
		// Token: 0x0601A304 RID: 107268 RVA: 0x00244F83 File Offset: 0x00243183
		public virtual void SetDuplicateNodes(int _arg)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SetDuplicateNodes_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A305 RID: 107269
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_SetGlobalExtent_16(HandleRef pThis, int imin, int imax, int jmin, int jmax, int kmin, int kmax);

		/// <summary>
		/// Set/Get the global extent array to be partitioned.
		/// The global extent is packed as follows:
		/// [imin,imax,jmin,jmax,kmin,kmax]
		/// </summary>
		// Token: 0x0601A306 RID: 107270 RVA: 0x00244F93 File Offset: 0x00243193
		public void SetGlobalExtent(int imin, int imax, int jmin, int jmax, int kmin, int kmax)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SetGlobalExtent_16(base.GetCppThis(), imin, imax, jmin, jmax, kmin, kmax);
		}

		// Token: 0x0601A307 RID: 107271
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_SetGlobalExtent_17(HandleRef pThis, IntPtr ext);

		/// <summary>
		/// Set/Get the global extent array to be partitioned.
		/// The global extent is packed as follows:
		/// [imin,imax,jmin,jmax,kmin,kmax]
		/// </summary>
		// Token: 0x0601A308 RID: 107272 RVA: 0x00244FAB File Offset: 0x002431AB
		public void SetGlobalExtent(IntPtr ext)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SetGlobalExtent_17(base.GetCppThis(), ext);
		}

		// Token: 0x0601A309 RID: 107273
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_SetNumberOfGhostLayers_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601A30A RID: 107274 RVA: 0x00244FBB File Offset: 0x002431BB
		public virtual void SetNumberOfGhostLayers(int _arg)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SetNumberOfGhostLayers_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A30B RID: 107275
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtentRCBPartitioner_SetNumberOfPartitions_19(HandleRef pThis, int N);

		/// <summary>
		/// Set/Get the number of requested partitions
		/// </summary>
		// Token: 0x0601A30C RID: 107276 RVA: 0x00244FCB File Offset: 0x002431CB
		public void SetNumberOfPartitions(int N)
		{
			vtkExtentRCBPartitioner.vtkExtentRCBPartitioner_SetNumberOfPartitions_19(base.GetCppThis(), N);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C69 RID: 7273
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtentRCBPartitioner";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C6A RID: 7274
		public new static readonly string MRClassNameKey = "class vtkExtentRCBPartitioner";
	}
}
