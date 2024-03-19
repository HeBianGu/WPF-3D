using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIntegerKey
	/// </summary>
	/// <remarks>
	///    Key for integer values in vtkInformation.
	///
	/// vtkInformationIntegerKey is used to represent keys for integer values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x020009DC RID: 2524
	public class vtkInformationIntegerKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A476 RID: 107638 RVA: 0x0024776C File Offset: 0x0024596C
		static vtkInformationIntegerKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIntegerKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIntegerKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A477 RID: 107639 RVA: 0x00247794 File Offset: 0x00245994
		public vtkInformationIntegerKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A478 RID: 107640 RVA: 0x002477A2 File Offset: 0x002459A2
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A479 RID: 107641
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A47A RID: 107642 RVA: 0x002477B0 File Offset: 0x002459B0
		public int Get(vtkInformation info)
		{
			return vtkInformationIntegerKey.vtkInformationIntegerKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A47B RID: 107643
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A47C RID: 107644 RVA: 0x002477E4 File Offset: 0x002459E4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIntegerKey.vtkInformationIntegerKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A47D RID: 107645
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIntegerKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A47E RID: 107646 RVA: 0x00247804 File Offset: 0x00245A04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIntegerKey.vtkInformationIntegerKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A47F RID: 107647
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A480 RID: 107648 RVA: 0x00247820 File Offset: 0x00245A20
		public override int IsA(string type)
		{
			return vtkInformationIntegerKey.vtkInformationIntegerKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A481 RID: 107649
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIntegerKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A482 RID: 107650 RVA: 0x00247840 File Offset: 0x00245A40
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIntegerKey.vtkInformationIntegerKey_IsTypeOf_05(type);
		}

		// Token: 0x0601A483 RID: 107651
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationIntegerKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A484 RID: 107652 RVA: 0x0024785C File Offset: 0x00245A5C
		public static vtkInformationIntegerKey MakeKey(string name, string location)
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerKey.vtkInformationIntegerKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601A485 RID: 107653
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A486 RID: 107654 RVA: 0x002478C8 File Offset: 0x00245AC8
		public new vtkInformationIntegerKey NewInstance()
		{
			vtkInformationIntegerKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerKey.vtkInformationIntegerKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A487 RID: 107655
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIntegerKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A488 RID: 107656 RVA: 0x00247924 File Offset: 0x00245B24
		public new static vtkInformationIntegerKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIntegerKey.vtkInformationIntegerKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x0601A489 RID: 107657
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerKey_Set_09(HandleRef pThis, HandleRef info, int arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A48A RID: 107658 RVA: 0x002479A4 File Offset: 0x00245BA4
		public void Set(vtkInformation info, int arg1)
		{
			vtkInformationIntegerKey.vtkInformationIntegerKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		// Token: 0x0601A48B RID: 107659
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIntegerKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601A48C RID: 107660 RVA: 0x002479D4 File Offset: 0x00245BD4
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIntegerKey.vtkInformationIntegerKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C88 RID: 7304
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIntegerKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C89 RID: 7305
		public new static readonly string MRClassNameKey = "class vtkInformationIntegerKey";
	}
}
