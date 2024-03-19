using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNetworkHierarchy
	/// </summary>
	/// <remarks>
	///    Filter that takes a graph and makes a
	/// tree out of the network ip addresses in that graph.
	///
	///
	/// Use SetInputArrayToProcess(0, ...) to set the array to that has
	/// the network ip addresses.
	/// Currently this array must be a vtkStringArray.
	/// </remarks>
	// Token: 0x02000687 RID: 1671
	public class vtkNetworkHierarchy : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011F25 RID: 73509 RVA: 0x00191F3B File Offset: 0x0019013B
		static vtkNetworkHierarchy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNetworkHierarchy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetworkHierarchy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011F26 RID: 73510 RVA: 0x00191F63 File Offset: 0x00190163
		public vtkNetworkHierarchy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011F27 RID: 73511
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetworkHierarchy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F28 RID: 73512 RVA: 0x00191F74 File Offset: 0x00190174
		public new static vtkNetworkHierarchy New()
		{
			vtkNetworkHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F29 RID: 73513 RVA: 0x00191FC8 File Offset: 0x001901C8
		public vtkNetworkHierarchy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNetworkHierarchy.vtkNetworkHierarchy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011F2A RID: 73514 RVA: 0x0019200C File Offset: 0x0019020C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011F2B RID: 73515
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetworkHierarchy_GetIPArrayName_01(HandleRef pThis);

		/// <summary>
		/// Used to store the ip array name
		/// </summary>
		// Token: 0x06011F2C RID: 73516 RVA: 0x00192018 File Offset: 0x00190218
		public virtual string GetIPArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkNetworkHierarchy.vtkNetworkHierarchy_GetIPArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011F2D RID: 73517
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetworkHierarchy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F2E RID: 73518 RVA: 0x00192054 File Offset: 0x00190254
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011F2F RID: 73519
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNetworkHierarchy_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F30 RID: 73520 RVA: 0x00192074 File Offset: 0x00190274
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011F31 RID: 73521
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetworkHierarchy_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F32 RID: 73522 RVA: 0x00192090 File Offset: 0x00190290
		public override int IsA(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011F33 RID: 73523
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNetworkHierarchy_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F34 RID: 73524 RVA: 0x001920B0 File Offset: 0x001902B0
		public new static int IsTypeOf(string type)
		{
			return vtkNetworkHierarchy.vtkNetworkHierarchy_IsTypeOf_05(type);
		}

		// Token: 0x06011F35 RID: 73525
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetworkHierarchy_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F36 RID: 73526 RVA: 0x001920CC File Offset: 0x001902CC
		public new vtkNetworkHierarchy NewInstance()
		{
			vtkNetworkHierarchy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011F37 RID: 73527
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNetworkHierarchy_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011F38 RID: 73528 RVA: 0x00192128 File Offset: 0x00190328
		public new static vtkNetworkHierarchy SafeDownCast(vtkObjectBase o)
		{
			vtkNetworkHierarchy vtkNetworkHierarchy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNetworkHierarchy.vtkNetworkHierarchy_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNetworkHierarchy = (vtkNetworkHierarchy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNetworkHierarchy.Register(null);
				}
			}
			return vtkNetworkHierarchy;
		}

		// Token: 0x06011F39 RID: 73529
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNetworkHierarchy_SetIPArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Used to store the ip array name
		/// </summary>
		// Token: 0x06011F3A RID: 73530 RVA: 0x001921A7 File Offset: 0x001903A7
		public virtual void SetIPArrayName(string _arg)
		{
			vtkNetworkHierarchy.vtkNetworkHierarchy_SetIPArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B7 RID: 5303
		public new const string MRFullTypeName = "Kitware.VTK.vtkNetworkHierarchy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014B8 RID: 5304
		public new static readonly string MRClassNameKey = "class vtkNetworkHierarchy";
	}
}
