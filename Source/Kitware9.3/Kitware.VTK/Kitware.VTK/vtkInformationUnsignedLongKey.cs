using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationUnsignedLongKey
	/// </summary>
	/// <remarks>
	///    Key for unsigned long values in vtkInformation.
	///
	/// vtkInformationUnsignedLongKey is used to represent keys for unsigned long values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x02000B68 RID: 2920
	public class vtkInformationUnsignedLongKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E801 RID: 124929 RVA: 0x002B42C8 File Offset: 0x002B24C8
		static vtkInformationUnsignedLongKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationUnsignedLongKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationUnsignedLongKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E802 RID: 124930 RVA: 0x002B42F0 File Offset: 0x002B24F0
		public vtkInformationUnsignedLongKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E803 RID: 124931 RVA: 0x002B42FE File Offset: 0x002B24FE
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E804 RID: 124932
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkInformationUnsignedLongKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E805 RID: 124933 RVA: 0x002B430C File Offset: 0x002B250C
		public uint Get(vtkInformation info)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E806 RID: 124934
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationUnsignedLongKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E807 RID: 124935 RVA: 0x002B4340 File Offset: 0x002B2540
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E808 RID: 124936
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationUnsignedLongKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E809 RID: 124937 RVA: 0x002B4360 File Offset: 0x002B2560
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E80A RID: 124938
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationUnsignedLongKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E80B RID: 124939 RVA: 0x002B437C File Offset: 0x002B257C
		public override int IsA(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E80C RID: 124940
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationUnsignedLongKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E80D RID: 124941 RVA: 0x002B439C File Offset: 0x002B259C
		public new static int IsTypeOf(string type)
		{
			return vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E80E RID: 124942
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationUnsignedLongKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationUnsignedLongKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E80F RID: 124943 RVA: 0x002B43B8 File Offset: 0x002B25B8
		public static vtkInformationUnsignedLongKey MakeKey(string name, string location)
		{
			vtkInformationUnsignedLongKey vtkInformationUnsignedLongKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationUnsignedLongKey = (vtkInformationUnsignedLongKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationUnsignedLongKey.Register(null);
				}
			}
			return vtkInformationUnsignedLongKey;
		}

		// Token: 0x0601E810 RID: 124944
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationUnsignedLongKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E811 RID: 124945 RVA: 0x002B4424 File Offset: 0x002B2624
		public new vtkInformationUnsignedLongKey NewInstance()
		{
			vtkInformationUnsignedLongKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationUnsignedLongKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E812 RID: 124946
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationUnsignedLongKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E813 RID: 124947 RVA: 0x002B4480 File Offset: 0x002B2680
		public new static vtkInformationUnsignedLongKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationUnsignedLongKey vtkInformationUnsignedLongKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationUnsignedLongKey = (vtkInformationUnsignedLongKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationUnsignedLongKey.Register(null);
				}
			}
			return vtkInformationUnsignedLongKey;
		}

		// Token: 0x0601E814 RID: 124948
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationUnsignedLongKey_Set_09(HandleRef pThis, HandleRef info, uint arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E815 RID: 124949 RVA: 0x002B4500 File Offset: 0x002B2700
		public void Set(vtkInformation info, uint arg1)
		{
			vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		// Token: 0x0601E816 RID: 124950
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationUnsignedLongKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E817 RID: 124951 RVA: 0x002B4530 File Offset: 0x002B2730
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationUnsignedLongKey.vtkInformationUnsignedLongKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AF RID: 8367
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationUnsignedLongKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020B0 RID: 8368
		public new static readonly string MRClassNameKey = "class vtkInformationUnsignedLongKey";
	}
}
