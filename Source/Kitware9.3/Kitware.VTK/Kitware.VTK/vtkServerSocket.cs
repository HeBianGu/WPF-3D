using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkServerSocket
	/// </summary>
	/// <remarks>
	///    Encapsulate a socket that accepts connections.
	///
	///
	/// </remarks>
	// Token: 0x02000AFB RID: 2811
	public class vtkServerSocket : vtkSocket
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D8A3 RID: 120995 RVA: 0x0029B9AF File Offset: 0x00299BAF
		static vtkServerSocket()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkServerSocket.MRClassNameKey, Type.GetType("Kitware.VTK.vtkServerSocket"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8A4 RID: 120996 RVA: 0x0029B9D7 File Offset: 0x00299BD7
		public vtkServerSocket(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D8A5 RID: 120997
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkServerSocket_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8A6 RID: 120998 RVA: 0x0029B9E8 File Offset: 0x00299BE8
		public new static vtkServerSocket New()
		{
			vtkServerSocket result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8A7 RID: 120999 RVA: 0x0029BA3C File Offset: 0x00299C3C
		public vtkServerSocket() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkServerSocket.vtkServerSocket_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D8A8 RID: 121000 RVA: 0x0029BA80 File Offset: 0x00299C80
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D8A9 RID: 121001
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkServerSocket_CreateServer_01(HandleRef pThis, int port);

		/// <summary>
		/// Creates a server socket at a given port and binds to it.
		/// Returns -1 on error. 0 on success.
		/// </summary>
		// Token: 0x0601D8AA RID: 121002 RVA: 0x0029BA8C File Offset: 0x00299C8C
		public int CreateServer(int port)
		{
			return vtkServerSocket.vtkServerSocket_CreateServer_01(base.GetCppThis(), port);
		}

		// Token: 0x0601D8AB RID: 121003
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkServerSocket_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8AC RID: 121004 RVA: 0x0029BAAC File Offset: 0x00299CAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkServerSocket.vtkServerSocket_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601D8AD RID: 121005
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkServerSocket_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8AE RID: 121006 RVA: 0x0029BACC File Offset: 0x00299CCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkServerSocket.vtkServerSocket_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601D8AF RID: 121007
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkServerSocket_GetServerPort_04(HandleRef pThis);

		/// <summary>
		/// Returns the port on which the server is running.
		/// </summary>
		// Token: 0x0601D8B0 RID: 121008 RVA: 0x0029BAE8 File Offset: 0x00299CE8
		public int GetServerPort()
		{
			return vtkServerSocket.vtkServerSocket_GetServerPort_04(base.GetCppThis());
		}

		// Token: 0x0601D8B1 RID: 121009
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkServerSocket_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8B2 RID: 121010 RVA: 0x0029BB08 File Offset: 0x00299D08
		public override int IsA(string type)
		{
			return vtkServerSocket.vtkServerSocket_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D8B3 RID: 121011
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkServerSocket_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8B4 RID: 121012 RVA: 0x0029BB28 File Offset: 0x00299D28
		public new static int IsTypeOf(string type)
		{
			return vtkServerSocket.vtkServerSocket_IsTypeOf_06(type);
		}

		// Token: 0x0601D8B5 RID: 121013
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkServerSocket_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8B6 RID: 121014 RVA: 0x0029BB44 File Offset: 0x00299D44
		public new vtkServerSocket NewInstance()
		{
			vtkServerSocket result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D8B7 RID: 121015
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkServerSocket_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D8B8 RID: 121016 RVA: 0x0029BBA0 File Offset: 0x00299DA0
		public new static vtkServerSocket SafeDownCast(vtkObjectBase o)
		{
			vtkServerSocket vtkServerSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkServerSocket = (vtkServerSocket)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkServerSocket.Register(null);
				}
			}
			return vtkServerSocket;
		}

		// Token: 0x0601D8B9 RID: 121017
		[DllImport("Kitware.VTK.CommonSystem.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkServerSocket_WaitForConnection_10(HandleRef pThis, uint msec, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Waits for a connection. When a connection is received
		/// a new vtkClientSocket object is created and returned.
		/// Returns nullptr on timeout.
		/// </summary>
		// Token: 0x0601D8BA RID: 121018 RVA: 0x0029BC20 File Offset: 0x00299E20
		public vtkClientSocket WaitForConnection(uint msec)
		{
			vtkClientSocket vtkClientSocket = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkServerSocket.vtkServerSocket_WaitForConnection_10(base.GetCppThis(), msec, ref mteStatus, ref maxValue, ref rawRefCount);
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
		// Token: 0x04001F1D RID: 7965
		public new const string MRFullTypeName = "Kitware.VTK.vtkServerSocket";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001F1E RID: 7966
		public new static readonly string MRClassNameKey = "class vtkServerSocket";
	}
}
