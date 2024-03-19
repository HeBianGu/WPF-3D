using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIntegerPointerKey
	/// </summary>
	/// <remarks>
	///    Key for pointer to integer.
	///
	/// vtkInformationIntegerPointerKey is used to represent keys for pointer
	/// to integer values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B5E RID: 2910
	public class vtkInformationIntegerPointerKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E6EB RID: 124651 RVA: 0x002B218C File Offset: 0x002B038C
		static vtkInformationIntegerPointerKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerPointerKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerPointerKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6EC RID: 124652 RVA: 0x002B21B4 File Offset: 0x002B03B4
		public vtkInformationIntegerPointerKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6ED RID: 124653 RVA: 0x002B21C2 File Offset: 0x002B03C2
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E6EE RID: 124654
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerPointerKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6EF RID: 124655 RVA: 0x002B21D0 File Offset: 0x002B03D0
		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E6F0 RID: 124656
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerPointerKey_Get_02(HandleRef pThis, HandleRef info, IntPtr value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6F1 RID: 124657 RVA: 0x002B2204 File Offset: 0x002B0404
		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E6F2 RID: 124658
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerPointerKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6F3 RID: 124659 RVA: 0x002B2234 File Offset: 0x002B0434
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E6F4 RID: 124660
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerPointerKey_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6F5 RID: 124661 RVA: 0x002B2254 File Offset: 0x002B0454
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E6F6 RID: 124662
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerPointerKey_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6F7 RID: 124663 RVA: 0x002B2270 File Offset: 0x002B0470
		public override int IsA(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E6F8 RID: 124664
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerPointerKey_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6F9 RID: 124665 RVA: 0x002B2290 File Offset: 0x002B0490
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_IsTypeOf_06(type);
		}

		// Token: 0x0601E6FA RID: 124666
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerPointerKey_Length_07(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6FB RID: 124667 RVA: 0x002B22AC File Offset: 0x002B04AC
		public int Length(vtkInformation info)
		{
			return vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E6FC RID: 124668
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerPointerKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6FD RID: 124669 RVA: 0x002B22E0 File Offset: 0x002B04E0
		public new vtkInformationIntegerPointerKey NewInstance()
		{
			vtkInformationIntegerPointerKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E6FE RID: 124670
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerPointerKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6FF RID: 124671 RVA: 0x002B233C File Offset: 0x002B053C
		public new static vtkInformationIntegerPointerKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerPointerKey vtkInformationIntegerPointerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerPointerKey = (vtkInformationIntegerPointerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerPointerKey.Register(null);
				}
			}
			return vtkInformationIntegerPointerKey;
		}

		// Token: 0x0601E700 RID: 124672
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerPointerKey_Set_10(HandleRef pThis, HandleRef info, IntPtr value, int length);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E701 RID: 124673 RVA: 0x002B23BC File Offset: 0x002B05BC
		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		// Token: 0x0601E702 RID: 124674
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerPointerKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E703 RID: 124675 RVA: 0x002B23F0 File Offset: 0x002B05F0
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIntegerPointerKey.vtkInformationIntegerPointerKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209B RID: 8347
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerPointerKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209C RID: 8348
		public new static readonly string MRClassNameKey = "class vtkInformationIntegerPointerKey";
	}
}
