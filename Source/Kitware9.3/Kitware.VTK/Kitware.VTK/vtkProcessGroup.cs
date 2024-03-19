using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProcessGroup
	/// </summary>
	/// <remarks>
	///    A subgroup of processes from a communicator.
	///
	///
	///
	/// This class is used for creating groups of processes.  A vtkProcessGroup is
	/// initialized by passing the controller or communicator on which the group is
	/// based off of.  You can then use the group to subset and reorder the
	/// processes.  Eventually, you can pass the group object to the
	/// CreateSubController method of vtkMultiProcessController to create a
	/// controller for the defined group of processes.  You must use the same
	/// controller (or attached communicator) from which this group was initialized
	/// with.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMultiProcessController, vtkCommunicator
	///
	/// @par Thanks:
	/// This class was originally written by Kenneth Moreland (kmorelndia.gov)
	/// from Sandia National Laboratories.
	///
	/// </seealso>
	// Token: 0x020006FA RID: 1786
	public class vtkProcessGroup : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012CEA RID: 77034 RVA: 0x001A786B File Offset: 0x001A5A6B
		static vtkProcessGroup()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProcessGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProcessGroup"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012CEB RID: 77035 RVA: 0x001A7893 File Offset: 0x001A5A93
		public vtkProcessGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012CEC RID: 77036
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CED RID: 77037 RVA: 0x001A78A4 File Offset: 0x001A5AA4
		public new static vtkProcessGroup New()
		{
			vtkProcessGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CEE RID: 77038 RVA: 0x001A78F8 File Offset: 0x001A5AF8
		public vtkProcessGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProcessGroup.vtkProcessGroup_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012CEF RID: 77039 RVA: 0x001A793C File Offset: 0x001A5B3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012CF0 RID: 77040
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_AddProcessId_01(HandleRef pThis, int processId);

		/// <summary>
		/// Add a process id to the end of the group (if it is not already in the
		/// group).  Returns the location where the id was stored.
		/// </summary>
		// Token: 0x06012CF1 RID: 77041 RVA: 0x001A7948 File Offset: 0x001A5B48
		public int AddProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_AddProcessId_01(base.GetCppThis(), processId);
		}

		// Token: 0x06012CF2 RID: 77042
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessGroup_Copy_02(HandleRef pThis, HandleRef group);

		/// <summary>
		/// Copies the given group's communicator and process ids.
		/// </summary>
		// Token: 0x06012CF3 RID: 77043 RVA: 0x001A7968 File Offset: 0x001A5B68
		public void Copy(vtkProcessGroup group)
		{
			vtkProcessGroup.vtkProcessGroup_Copy_02(base.GetCppThis(), (group == null) ? default(HandleRef) : group.GetCppThis());
		}

		// Token: 0x06012CF4 RID: 77044
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_FindProcessId_03(HandleRef pThis, int processId);

		/// <summary>
		/// Given a process id in the communicator, this method returns its location in
		/// the group or -1 if it is not in the group.  For example, if this group
		/// contains {6, 2, 8, 1}, then FindProcessId(2) will return 1 and
		/// FindProcessId(3) will return -1.
		/// </summary>
		// Token: 0x06012CF5 RID: 77045 RVA: 0x001A7998 File Offset: 0x001A5B98
		public int FindProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_FindProcessId_03(base.GetCppThis(), processId);
		}

		// Token: 0x06012CF6 RID: 77046
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessGroup_GetCommunicator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the communicator on which this group is based on.
		/// </summary>
		// Token: 0x06012CF7 RID: 77047 RVA: 0x001A79B8 File Offset: 0x001A5BB8
		public virtual vtkCommunicator GetCommunicator()
		{
			vtkCommunicator vtkCommunicator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_GetCommunicator_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommunicator = (vtkCommunicator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommunicator.Register(null);
				}
			}
			return vtkCommunicator;
		}

		// Token: 0x06012CF8 RID: 77048
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_GetLocalProcessId_05(HandleRef pThis);

		/// <summary>
		/// Get the process id for the local process (as defined by the group's
		/// communicator).  Returns -1 if the local process is not in the group.
		/// </summary>
		// Token: 0x06012CF9 RID: 77049 RVA: 0x001A7A28 File Offset: 0x001A5C28
		public int GetLocalProcessId()
		{
			return vtkProcessGroup.vtkProcessGroup_GetLocalProcessId_05(base.GetCppThis());
		}

		// Token: 0x06012CFA RID: 77050
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcessGroup_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CFB RID: 77051 RVA: 0x001A7A48 File Offset: 0x001A5C48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06012CFC RID: 77052
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProcessGroup_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012CFD RID: 77053 RVA: 0x001A7A68 File Offset: 0x001A5C68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06012CFE RID: 77054
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_GetNumberOfProcessIds_08(HandleRef pThis);

		/// <summary>
		/// Returns the size of this group (the number of processes defined in it).
		/// </summary>
		// Token: 0x06012CFF RID: 77055 RVA: 0x001A7A84 File Offset: 0x001A5C84
		public virtual int GetNumberOfProcessIds()
		{
			return vtkProcessGroup.vtkProcessGroup_GetNumberOfProcessIds_08(base.GetCppThis());
		}

		// Token: 0x06012D00 RID: 77056
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_GetProcessId_09(HandleRef pThis, int pos);

		/// <summary>
		/// Given a position in the group, returns the id of the process in the
		/// communicator this group is based on.  For example, if this group contains
		/// {6, 2, 8, 1}, then GetProcessId(2) will return 8 and GetProcessId(3) will
		/// return 1.
		/// </summary>
		// Token: 0x06012D01 RID: 77057 RVA: 0x001A7AA4 File Offset: 0x001A5CA4
		public int GetProcessId(int pos)
		{
			return vtkProcessGroup.vtkProcessGroup_GetProcessId_09(base.GetCppThis(), pos);
		}

		// Token: 0x06012D02 RID: 77058
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessGroup_Initialize_10(HandleRef pThis, HandleRef controller);

		/// <summary>
		/// Initialize the group to the given controller or communicator.  The group
		/// will be set to contain all of the processes in the controller/communicator
		/// in the same order.
		/// </summary>
		// Token: 0x06012D03 RID: 77059 RVA: 0x001A7AC4 File Offset: 0x001A5CC4
		public void Initialize(vtkMultiProcessController controller)
		{
			vtkProcessGroup.vtkProcessGroup_Initialize_10(base.GetCppThis(), (controller == null) ? default(HandleRef) : controller.GetCppThis());
		}

		// Token: 0x06012D04 RID: 77060
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessGroup_Initialize_11(HandleRef pThis, HandleRef communicator);

		/// <summary>
		/// Initialize the group to the given controller or communicator.  The group
		/// will be set to contain all of the processes in the controller/communicator
		/// in the same order.
		/// </summary>
		// Token: 0x06012D05 RID: 77061 RVA: 0x001A7AF4 File Offset: 0x001A5CF4
		public void Initialize(vtkCommunicator communicator)
		{
			vtkProcessGroup.vtkProcessGroup_Initialize_11(base.GetCppThis(), (communicator == null) ? default(HandleRef) : communicator.GetCppThis());
		}

		// Token: 0x06012D06 RID: 77062
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D07 RID: 77063 RVA: 0x001A7B24 File Offset: 0x001A5D24
		public override int IsA(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06012D08 RID: 77064
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D09 RID: 77065 RVA: 0x001A7B44 File Offset: 0x001A5D44
		public new static int IsTypeOf(string type)
		{
			return vtkProcessGroup.vtkProcessGroup_IsTypeOf_13(type);
		}

		// Token: 0x06012D0A RID: 77066
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessGroup_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D0B RID: 77067 RVA: 0x001A7B60 File Offset: 0x001A5D60
		public new vtkProcessGroup NewInstance()
		{
			vtkProcessGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012D0C RID: 77068
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessGroup_RemoveAllProcessIds_16(HandleRef pThis);

		/// <summary>
		/// Removes all the processes ids from the group, leaving the group empty.
		/// </summary>
		// Token: 0x06012D0D RID: 77069 RVA: 0x001A7BBA File Offset: 0x001A5DBA
		public void RemoveAllProcessIds()
		{
			vtkProcessGroup.vtkProcessGroup_RemoveAllProcessIds_16(base.GetCppThis());
		}

		// Token: 0x06012D0E RID: 77070
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProcessGroup_RemoveProcessId_17(HandleRef pThis, int processId);

		/// <summary>
		/// Remove the given process id from the group (assuming it is in the group).
		/// All ids to the "right" of the removed id are shifted over.  Returns 1
		/// if the process id was removed, 0 if the process id was not in the group
		/// in the first place.
		/// </summary>
		// Token: 0x06012D0F RID: 77071 RVA: 0x001A7BCC File Offset: 0x001A5DCC
		public int RemoveProcessId(int processId)
		{
			return vtkProcessGroup.vtkProcessGroup_RemoveProcessId_17(base.GetCppThis(), processId);
		}

		// Token: 0x06012D10 RID: 77072
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProcessGroup_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012D11 RID: 77073 RVA: 0x001A7BEC File Offset: 0x001A5DEC
		public new static vtkProcessGroup SafeDownCast(vtkObjectBase o)
		{
			vtkProcessGroup vtkProcessGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProcessGroup.vtkProcessGroup_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProcessGroup = (vtkProcessGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProcessGroup.Register(null);
				}
			}
			return vtkProcessGroup;
		}

		// Token: 0x06012D12 RID: 77074
		[DllImport("Kitware.VTK.ParallelCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkProcessGroup_SetCommunicator_19(HandleRef pThis, HandleRef communicator);

		/// <summary>
		/// Set the communicator.  This has the same effect as Initialize except that
		/// the contents of the group will not be modified (although they may be
		/// truncated if the new communicator is smaller than the current group).
		/// Note that this can lead to an invalid group if there are values in the
		/// group that are not valid in the new communicator.
		/// </summary>
		// Token: 0x06012D13 RID: 77075 RVA: 0x001A7C6C File Offset: 0x001A5E6C
		public void SetCommunicator(vtkCommunicator communicator)
		{
			vtkProcessGroup.vtkProcessGroup_SetCommunicator_19(base.GetCppThis(), (communicator == null) ? default(HandleRef) : communicator.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BB RID: 5563
		public new const string MRFullTypeName = "Kitware.VTK.vtkProcessGroup";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015BC RID: 5564
		public new static readonly string MRClassNameKey = "class vtkProcessGroup";
	}
}
