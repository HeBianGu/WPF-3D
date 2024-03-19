using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClientSocket
	/// </summary>
	/// <remarks>
	///    Encapsulates a client socket.
	/// </remarks>
	// Token: 0x02000AF8 RID: 2808
	public class vtkClientSocket : vtkSocket
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D831 RID: 120881 RVA: 0x0029AF21 File Offset: 0x00299121
		static vtkClientSocket()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClientSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClientSocket"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D832 RID: 120882 RVA: 0x0029AF49 File Offset: 0x00299149
		public vtkClientSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D833 RID: 120883
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClientSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D834 RID: 120884 RVA: 0x0029AF58 File Offset: 0x00299158
		public new static vtkClientSocket New()
		{
			vtkClientSocket result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D835 RID: 120885 RVA: 0x0029AFAC File Offset: 0x002991AC
		public vtkClientSocket() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClientSocket.vtkClientSocket_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D836 RID: 120886 RVA: 0x0029AFF0 File Offset: 0x002991F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D837 RID: 120887
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClientSocket_ConnectToServer_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string hostname, int port);

		/// <summary>
		/// Connects to host. Returns 0 on success, -1 on error.
		/// </summary>
		// Token: 0x0601D838 RID: 120888 RVA: 0x0029AFFC File Offset: 0x002991FC
		public int ConnectToServer(string hostname, int port)
		{
			return vtkClientSocket.vtkClientSocket_ConnectToServer_01(base.GetCppThis(), hostname, port);
		}

		// Token: 0x0601D839 RID: 120889
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkClientSocket_GetConnectingSide_02(HandleRef pThis);

		/// <summary>
		/// Returns if the socket is on the connecting side (the side that requests a
		/// ConnectToServer() or on the connected side (the side that was waiting for
		/// the client to connect). This is used to disambiguate the two ends of a socket
		/// connection.
		/// </summary>
		// Token: 0x0601D83A RID: 120890 RVA: 0x0029B020 File Offset: 0x00299220
		public virtual bool GetConnectingSide()
		{
			return vtkClientSocket.vtkClientSocket_GetConnectingSide_02(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D83B RID: 120891
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClientSocket_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D83C RID: 120892 RVA: 0x0029B048 File Offset: 0x00299248
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClientSocket.vtkClientSocket_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D83D RID: 120893
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClientSocket_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D83E RID: 120894 RVA: 0x0029B068 File Offset: 0x00299268
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClientSocket.vtkClientSocket_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D83F RID: 120895
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClientSocket_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D840 RID: 120896 RVA: 0x0029B084 File Offset: 0x00299284
		public override int IsA(string type)
		{
			return vtkClientSocket.vtkClientSocket_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D841 RID: 120897
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClientSocket_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D842 RID: 120898 RVA: 0x0029B0A4 File Offset: 0x002992A4
		public new static int IsTypeOf(string type)
		{
			return vtkClientSocket.vtkClientSocket_IsTypeOf_06(type);
		}

		// Token: 0x0601D843 RID: 120899
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClientSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D844 RID: 120900 RVA: 0x0029B0C0 File Offset: 0x002992C0
		public new vtkClientSocket NewInstance()
		{
			vtkClientSocket result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D845 RID: 120901
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClientSocket_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D846 RID: 120902 RVA: 0x0029B11C File Offset: 0x0029931C
		public new static vtkClientSocket SafeDownCast(vtkObjectBase o)
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClientSocket.vtkClientSocket_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClientSocket = (vtkClientSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClientSocket.Register(null);
				}
			}
			return vtkClientSocket;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F17 RID: 7959
		public new const string MRFullTypeName = "Kitware.VTK.vtkClientSocket";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F18 RID: 7960
		public new static readonly string MRClassNameKey = "class vtkClientSocket";
	}
}
