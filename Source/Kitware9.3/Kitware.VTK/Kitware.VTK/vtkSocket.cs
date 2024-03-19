using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSocket
	/// </summary>
	/// <remarks>
	///    BSD socket encapsulation.
	///
	/// This abstract class encapsulates a BSD socket. It provides an API for
	/// basic socket operations.
	/// </remarks>
	// Token: 0x02000AF7 RID: 2807
	public class vtkSocket : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D816 RID: 120854 RVA: 0x0029ACD5 File Offset: 0x00298ED5
		static vtkSocket()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSocket"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D817 RID: 120855 RVA: 0x0029ACFD File Offset: 0x00298EFD
		public vtkSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D818 RID: 120856 RVA: 0x0029AD0B File Offset: 0x00298F0B
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D819 RID: 120857
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSocket_CloseSocket_01(HandleRef pThis);

		/// <summary>
		/// Close the socket.
		/// </summary>
		// Token: 0x0601D81A RID: 120858 RVA: 0x0029AD16 File Offset: 0x00298F16
		public void CloseSocket()
		{
			vtkSocket.vtkSocket_CloseSocket_01(base.GetCppThis());
		}

		// Token: 0x0601D81B RID: 120859
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_GetConnected_02(HandleRef pThis);

		/// <summary>
		/// Check is the socket is alive.
		/// </summary>
		// Token: 0x0601D81C RID: 120860 RVA: 0x0029AD28 File Offset: 0x00298F28
		public int GetConnected()
		{
			return vtkSocket.vtkSocket_GetConnected_02(base.GetCppThis());
		}

		// Token: 0x0601D81D RID: 120861
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocket_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D81E RID: 120862 RVA: 0x0029AD48 File Offset: 0x00298F48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSocket.vtkSocket_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D81F RID: 120863
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSocket_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D820 RID: 120864 RVA: 0x0029AD68 File Offset: 0x00298F68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSocket.vtkSocket_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D821 RID: 120865
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_GetSocketDescriptor_05(HandleRef pThis);

		/// <summary>
		/// Provides access to the internal socket descriptor. This is valid only when
		/// GetConnected() returns true.
		/// </summary>
		// Token: 0x0601D822 RID: 120866 RVA: 0x0029AD84 File Offset: 0x00298F84
		public virtual int GetSocketDescriptor()
		{
			return vtkSocket.vtkSocket_GetSocketDescriptor_05(base.GetCppThis());
		}

		// Token: 0x0601D823 RID: 120867
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D824 RID: 120868 RVA: 0x0029ADA4 File Offset: 0x00298FA4
		public override int IsA(string type)
		{
			return vtkSocket.vtkSocket_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601D825 RID: 120869
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D826 RID: 120870 RVA: 0x0029ADC4 File Offset: 0x00298FC4
		public new static int IsTypeOf(string type)
		{
			return vtkSocket.vtkSocket_IsTypeOf_07(type);
		}

		// Token: 0x0601D827 RID: 120871
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D828 RID: 120872 RVA: 0x0029ADE0 File Offset: 0x00298FE0
		public new vtkSocket NewInstance()
		{
			vtkSocket result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocket.vtkSocket_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D829 RID: 120873
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_Receive_09(HandleRef pThis, IntPtr data, int length, int readFully);

		/// <summary>
		/// Receive data from the socket.
		/// This call blocks until some data is read from the socket.
		/// When readFully is set, this call will block until all the
		/// requested data is read from the socket.
		/// 0 on error, else number of bytes read is returned. On error,
		/// vtkCommand::ErrorEvent is raised.
		/// </summary>
		// Token: 0x0601D82A RID: 120874 RVA: 0x0029AE3C File Offset: 0x0029903C
		public int Receive(IntPtr data, int length, int readFully)
		{
			return vtkSocket.vtkSocket_Receive_09(base.GetCppThis(), data, length, readFully);
		}

		// Token: 0x0601D82B RID: 120875
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSocket_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D82C RID: 120876 RVA: 0x0029AE60 File Offset: 0x00299060
		public new static vtkSocket SafeDownCast(vtkObjectBase o)
		{
			vtkSocket vtkSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSocket.vtkSocket_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSocket = (vtkSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSocket.Register(null);
				}
			}
			return vtkSocket;
		}

		// Token: 0x0601D82D RID: 120877
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_SelectSockets_11(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index);

		/// <summary>
		/// Selects set of sockets. Returns 0 on timeout, -1 on error.
		/// 1 on success. Selected socket's index is returned through
		/// selected_index
		/// </summary>
		// Token: 0x0601D82E RID: 120878 RVA: 0x0029AEE0 File Offset: 0x002990E0
		public static int SelectSockets(IntPtr sockets_to_select, int size, uint msec, IntPtr selected_index)
		{
			return vtkSocket.vtkSocket_SelectSockets_11(sockets_to_select, size, msec, selected_index);
		}

		// Token: 0x0601D82F RID: 120879
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSocket_Send_12(HandleRef pThis, IntPtr data, int length);

		/// <summary>
		/// These methods send data over the socket.
		/// Returns 1 on success, 0 on error and raises vtkCommand::ErrorEvent.
		/// </summary>
		// Token: 0x0601D830 RID: 120880 RVA: 0x0029AF00 File Offset: 0x00299100
		public int Send(IntPtr data, int length)
		{
			return vtkSocket.vtkSocket_Send_12(base.GetCppThis(), data, length);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F15 RID: 7957
		public new const string MRFullTypeName = "Kitware.VTK.vtkSocket";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F16 RID: 7958
		public new static readonly string MRClassNameKey = "class vtkSocket";
	}
}
