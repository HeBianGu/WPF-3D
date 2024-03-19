using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationDoubleVectorKey
	/// </summary>
	/// <remarks>
	///    Key for double vector values.
	///
	/// vtkInformationDoubleVectorKey is used to represent keys for double
	/// vector values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B5A RID: 2906
	public class vtkInformationDoubleVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E683 RID: 124547 RVA: 0x002B14DC File Offset: 0x002AF6DC
		static vtkInformationDoubleVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDoubleVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDoubleVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E684 RID: 124548 RVA: 0x002B1504 File Offset: 0x002AF704
		public vtkInformationDoubleVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E685 RID: 124549 RVA: 0x002B1512 File Offset: 0x002AF712
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E686 RID: 124550
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleVectorKey_Append_01(HandleRef pThis, HandleRef info, double value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E687 RID: 124551 RVA: 0x002B1520 File Offset: 0x002AF720
		public void Append(vtkInformation info, double value)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E688 RID: 124552
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleVectorKey_Get_02(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E689 RID: 124553 RVA: 0x002B1550 File Offset: 0x002AF750
		public IntPtr Get(vtkInformation info)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E68A RID: 124554
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInformationDoubleVectorKey_Get_03(HandleRef pThis, HandleRef info, int idx);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E68B RID: 124555 RVA: 0x002B1584 File Offset: 0x002AF784
		public double Get(vtkInformation info, int idx)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_03(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx);
		}

		// Token: 0x0601E68C RID: 124556
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleVectorKey_Get_04(HandleRef pThis, HandleRef info, IntPtr value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E68D RID: 124557 RVA: 0x002B15BC File Offset: 0x002AF7BC
		public void Get(vtkInformation info, IntPtr value)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Get_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E68E RID: 124558
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDoubleVectorKey_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E68F RID: 124559 RVA: 0x002B15EC File Offset: 0x002AF7EC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E690 RID: 124560
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDoubleVectorKey_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E691 RID: 124561 RVA: 0x002B160C File Offset: 0x002AF80C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601E692 RID: 124562
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDoubleVectorKey_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E693 RID: 124563 RVA: 0x002B1628 File Offset: 0x002AF828
		public override int IsA(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601E694 RID: 124564
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDoubleVectorKey_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E695 RID: 124565 RVA: 0x002B1648 File Offset: 0x002AF848
		public new static int IsTypeOf(string type)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_IsTypeOf_08(type);
		}

		// Token: 0x0601E696 RID: 124566
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDoubleVectorKey_Length_09(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E697 RID: 124567 RVA: 0x002B1664 File Offset: 0x002AF864
		public int Length(vtkInformation info)
		{
			return vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Length_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E698 RID: 124568
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleVectorKey_MakeKey_10([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, int length, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationDoubleVectorKey, given a
		/// name, a location and a required length. This method is provided for
		/// wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E699 RID: 124569 RVA: 0x002B1698 File Offset: 0x002AF898
		public static vtkInformationDoubleVectorKey MakeKey(string name, string location, int length)
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_MakeKey_10(name, location, length, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601E69A RID: 124570
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleVectorKey_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E69B RID: 124571 RVA: 0x002B1704 File Offset: 0x002AF904
		public new vtkInformationDoubleVectorKey NewInstance()
		{
			vtkInformationDoubleVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E69C RID: 124572
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleVectorKey_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E69D RID: 124573 RVA: 0x002B1760 File Offset: 0x002AF960
		public new static vtkInformationDoubleVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDoubleVectorKey vtkInformationDoubleVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleVectorKey = (vtkInformationDoubleVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleVectorKey.Register(null);
				}
			}
			return vtkInformationDoubleVectorKey;
		}

		// Token: 0x0601E69E RID: 124574
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleVectorKey_Set_13(HandleRef pThis, HandleRef info, IntPtr value, int length);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E69F RID: 124575 RVA: 0x002B17E0 File Offset: 0x002AF9E0
		public void Set(vtkInformation info, IntPtr value, int length)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_Set_13(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, length);
		}

		// Token: 0x0601E6A0 RID: 124576
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleVectorKey_ShallowCopy_14(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E6A1 RID: 124577 RVA: 0x002B1814 File Offset: 0x002AFA14
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationDoubleVectorKey.vtkInformationDoubleVectorKey_ShallowCopy_14(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002093 RID: 8339
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDoubleVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002094 RID: 8340
		public new static readonly string MRClassNameKey = "class vtkInformationDoubleVectorKey";
	}
}
