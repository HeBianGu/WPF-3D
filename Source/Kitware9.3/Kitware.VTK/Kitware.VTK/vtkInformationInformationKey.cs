using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationInformationKey
	/// </summary>
	/// <remarks>
	///    Key for vtkInformation values.
	///
	/// vtkInformationInformationKey is used to represent keys in vtkInformation
	/// for other information objects.
	/// </remarks>
	// Token: 0x02000B5C RID: 2908
	public class vtkInformationInformationKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E6B9 RID: 124601 RVA: 0x002B1B04 File Offset: 0x002AFD04
		static vtkInformationInformationKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationInformationKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationInformationKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6BA RID: 124602 RVA: 0x002B1B2C File Offset: 0x002AFD2C
		public vtkInformationInformationKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6BB RID: 124603 RVA: 0x002B1B3A File Offset: 0x002AFD3A
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E6BC RID: 124604
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationKey_DeepCopy_01(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Duplicate (new instance created) the entry associated with this key from
		/// one information object to another (new instances of any contained
		/// vtkInformation and vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E6BD RID: 124605 RVA: 0x002B1B48 File Offset: 0x002AFD48
		public override void DeepCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationKey.vtkInformationInformationKey_DeepCopy_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		// Token: 0x0601E6BE RID: 124606
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationKey_Get_02(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6BF RID: 124607 RVA: 0x002B1B8C File Offset: 0x002AFD8C
		public vtkInformation Get(vtkInformation info)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationKey.vtkInformationInformationKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601E6C0 RID: 124608
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationInformationKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6C1 RID: 124609 RVA: 0x002B1C14 File Offset: 0x002AFE14
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationInformationKey.vtkInformationInformationKey_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E6C2 RID: 124610
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationInformationKey_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6C3 RID: 124611 RVA: 0x002B1C34 File Offset: 0x002AFE34
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationInformationKey.vtkInformationInformationKey_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E6C4 RID: 124612
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationInformationKey_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6C5 RID: 124613 RVA: 0x002B1C50 File Offset: 0x002AFE50
		public override int IsA(string type)
		{
			return vtkInformationInformationKey.vtkInformationInformationKey_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E6C6 RID: 124614
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationInformationKey_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6C7 RID: 124615 RVA: 0x002B1C70 File Offset: 0x002AFE70
		public new static int IsTypeOf(string type)
		{
			return vtkInformationInformationKey.vtkInformationInformationKey_IsTypeOf_06(type);
		}

		// Token: 0x0601E6C8 RID: 124616
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationKey_MakeKey_07([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationInformationKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E6C9 RID: 124617 RVA: 0x002B1C8C File Offset: 0x002AFE8C
		public static vtkInformationInformationKey MakeKey(string name, string location)
		{
			vtkInformationInformationKey vtkInformationInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationKey.vtkInformationInformationKey_MakeKey_07(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationKey = (vtkInformationInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationKey.Register(null);
				}
			}
			return vtkInformationInformationKey;
		}

		// Token: 0x0601E6CA RID: 124618
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationKey_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6CB RID: 124619 RVA: 0x002B1CF8 File Offset: 0x002AFEF8
		public new vtkInformationInformationKey NewInstance()
		{
			vtkInformationInformationKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationKey.vtkInformationInformationKey_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E6CC RID: 124620
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationInformationKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6CD RID: 124621 RVA: 0x002B1D54 File Offset: 0x002AFF54
		public new static vtkInformationInformationKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationInformationKey vtkInformationInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationInformationKey.vtkInformationInformationKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationInformationKey = (vtkInformationInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationInformationKey.Register(null);
				}
			}
			return vtkInformationInformationKey;
		}

		// Token: 0x0601E6CE RID: 124622
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationKey_Set_10(HandleRef pThis, HandleRef info, HandleRef arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6CF RID: 124623 RVA: 0x002B1DD4 File Offset: 0x002AFFD4
		public void Set(vtkInformation info, vtkInformation arg1)
		{
			vtkInformationInformationKey.vtkInformationInformationKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E6D0 RID: 124624
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationInformationKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E6D1 RID: 124625 RVA: 0x002B1E18 File Offset: 0x002B0018
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationInformationKey.vtkInformationInformationKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002097 RID: 8343
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationInformationKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002098 RID: 8344
		public new static readonly string MRClassNameKey = "class vtkInformationInformationKey";
	}
}
