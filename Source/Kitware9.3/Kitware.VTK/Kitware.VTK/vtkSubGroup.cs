using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSubGroup
	/// </summary>
	/// <remarks>
	///    scalable collective communication for a
	///      subset of members of a parallel VTK application
	///
	///
	///     This class provides scalable broadcast, reduce, etc. using
	///     only a vtkMultiProcessController. It does not require MPI.
	///     Users are vtkPKdTree and vtkDistributedDataFilter.
	///
	/// @attention
	/// This class will be deprecated soon.  Instead of using this class, use the
	/// collective and subgrouping operations now built into
	/// vtkMultiProcessController.  The only reason this class is not deprecated
	/// already is because vtkPKdTree relies heavily on this class in ways that are
	/// not easy to work around.  Since vtkPKdTree is due for a major overhaul
	/// anyway, we are leaving things the way they are for now.
	///
	/// </remarks>
	/// <seealso>
	///
	///      vtkPKdTree vtkDistributedDataFilter
	/// </seealso>
	// Token: 0x02000700 RID: 1792
	public class vtkSubGroup : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012DDA RID: 77274 RVA: 0x001A8DF3 File Offset: 0x001A6FF3
		static vtkSubGroup()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubGroup"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012DDB RID: 77275 RVA: 0x001A8E1B File Offset: 0x001A701B
		public vtkSubGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012DDC RID: 77276
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DDD RID: 77277 RVA: 0x001A8E2C File Offset: 0x001A702C
		public new static vtkSubGroup New()
		{
			vtkSubGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DDE RID: 77278 RVA: 0x001A8E80 File Offset: 0x001A7080
		public vtkSubGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSubGroup.vtkSubGroup_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012DDF RID: 77279 RVA: 0x001A8EC4 File Offset: 0x001A70C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012DE0 RID: 77280
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Barrier_01(HandleRef pThis);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DE1 RID: 77281 RVA: 0x001A8ED0 File Offset: 0x001A70D0
		public int Barrier()
		{
			return vtkSubGroup.vtkSubGroup_Barrier_01(base.GetCppThis());
		}

		// Token: 0x06012DE2 RID: 77282
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Broadcast_02(HandleRef pThis, IntPtr data, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DE3 RID: 77283 RVA: 0x001A8EF0 File Offset: 0x001A70F0
		public int Broadcast(IntPtr data, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Broadcast_02(base.GetCppThis(), data, length, root);
		}

		// Token: 0x06012DE4 RID: 77284
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Broadcast_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DE5 RID: 77285 RVA: 0x001A8F14 File Offset: 0x001A7114
		public int Broadcast(string data, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Broadcast_03(base.GetCppThis(), data, length, root);
		}

		// Token: 0x06012DE6 RID: 77286
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Gather_04(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DE7 RID: 77287 RVA: 0x001A8F38 File Offset: 0x001A7138
		public int Gather(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Gather_04(base.GetCppThis(), data, to, length, root);
		}

		// Token: 0x06012DE8 RID: 77288
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Gather_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string data, [MarshalAs(UnmanagedType.LPUTF8Str)] string to, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DE9 RID: 77289 RVA: 0x001A8F5C File Offset: 0x001A715C
		public int Gather(string data, string to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_Gather_05(base.GetCppThis(), data, to, length, root);
		}

		// Token: 0x06012DEA RID: 77290
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubGroup_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DEB RID: 77291 RVA: 0x001A8F80 File Offset: 0x001A7180
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSubGroup.vtkSubGroup_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06012DEC RID: 77292
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubGroup_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DED RID: 77293 RVA: 0x001A8FA0 File Offset: 0x001A71A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSubGroup.vtkSubGroup_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06012DEE RID: 77294
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_Initialize_08(HandleRef pThis, int p0, int p1, int me, int tag, HandleRef c);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DEF RID: 77295 RVA: 0x001A8FBC File Offset: 0x001A71BC
		public int Initialize(int p0, int p1, int me, int tag, vtkCommunicator c)
		{
			return vtkSubGroup.vtkSubGroup_Initialize_08(base.GetCppThis(), p0, p1, me, tag, (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x06012DF0 RID: 77296
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DF1 RID: 77297 RVA: 0x001A8FF8 File Offset: 0x001A71F8
		public override int IsA(string type)
		{
			return vtkSubGroup.vtkSubGroup_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06012DF2 RID: 77298
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DF3 RID: 77299 RVA: 0x001A9018 File Offset: 0x001A7218
		public new static int IsTypeOf(string type)
		{
			return vtkSubGroup.vtkSubGroup_IsTypeOf_10(type);
		}

		// Token: 0x06012DF4 RID: 77300
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubGroup_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DF5 RID: 77301 RVA: 0x001A9034 File Offset: 0x001A7234
		public new vtkSubGroup NewInstance()
		{
			vtkSubGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012DF6 RID: 77302
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubGroup_PrintSubGroup_13(HandleRef pThis);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DF7 RID: 77303 RVA: 0x001A908E File Offset: 0x001A728E
		public void PrintSubGroup()
		{
			vtkSubGroup.vtkSubGroup_PrintSubGroup_13(base.GetCppThis());
		}

		// Token: 0x06012DF8 RID: 77304
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_ReduceMax_14(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DF9 RID: 77305 RVA: 0x001A90A0 File Offset: 0x001A72A0
		public int ReduceMax(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceMax_14(base.GetCppThis(), data, to, length, root);
		}

		// Token: 0x06012DFA RID: 77306
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_ReduceMin_15(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DFB RID: 77307 RVA: 0x001A90C4 File Offset: 0x001A72C4
		public int ReduceMin(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceMin_15(base.GetCppThis(), data, to, length, root);
		}

		// Token: 0x06012DFC RID: 77308
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_ReduceSum_16(HandleRef pThis, IntPtr data, IntPtr to, int length, int root);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012DFD RID: 77309 RVA: 0x001A90E8 File Offset: 0x001A72E8
		public int ReduceSum(IntPtr data, IntPtr to, int length, int root)
		{
			return vtkSubGroup.vtkSubGroup_ReduceSum_16(base.GetCppThis(), data, to, length, root);
		}

		// Token: 0x06012DFE RID: 77310
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubGroup_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012DFF RID: 77311 RVA: 0x001A910C File Offset: 0x001A730C
		public new static vtkSubGroup SafeDownCast(vtkObjectBase o)
		{
			vtkSubGroup vtkSubGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubGroup.vtkSubGroup_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubGroup = (vtkSubGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubGroup.Register(null);
				}
			}
			return vtkSubGroup;
		}

		// Token: 0x06012E00 RID: 77312
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubGroup_getLocalRank_18(HandleRef pThis, int processID);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012E01 RID: 77313 RVA: 0x001A918C File Offset: 0x001A738C
		public int getLocalRank(int processID)
		{
			return vtkSubGroup.vtkSubGroup_getLocalRank_18(base.GetCppThis(), processID);
		}

		// Token: 0x06012E02 RID: 77314
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubGroup_setGatherPattern_19(HandleRef pThis, int root, int length);

		/// <summary>
		/// Initialize a communication subgroup for the processes
		/// with rank p0 through p1 of the given communicator.  (So
		/// vtkSubGroup is limited to working with subgroups that
		/// are identified by a contiguous set of rank IDs.)
		/// The third argument is the callers rank, which must
		/// in the range from p0 through p1.
		/// </summary>
		// Token: 0x06012E03 RID: 77315 RVA: 0x001A91AC File Offset: 0x001A73AC
		public void setGatherPattern(int root, int length)
		{
			vtkSubGroup.vtkSubGroup_setGatherPattern_19(base.GetCppThis(), root, length);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015CA RID: 5578
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubGroup";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015CB RID: 5579
		public new static readonly string MRClassNameKey = "class vtkSubGroup";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000701 RID: 1793
		public enum MAXOP_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040015CD RID: 5581
			MAXOP = 2,
			/// <summary>enum member</summary>
			// Token: 0x040015CE RID: 5582
			MINOP = 1,
			/// <summary>enum member</summary>
			// Token: 0x040015CF RID: 5583
			SUMOP = 3
		}
	}
}
