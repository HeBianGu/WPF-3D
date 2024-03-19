using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationStringKey
	/// </summary>
	/// <remarks>
	///    Key for string values in vtkInformation.
	///
	/// vtkInformationStringKey is used to represent keys for string values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x02000B66 RID: 2918
	public class vtkInformationStringKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E7CF RID: 124879 RVA: 0x002B3CD0 File Offset: 0x002B1ED0
		static vtkInformationStringKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationStringKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationStringKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7D0 RID: 124880 RVA: 0x002B3CF8 File Offset: 0x002B1EF8
		public vtkInformationStringKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7D1 RID: 124881 RVA: 0x002B3D06 File Offset: 0x002B1F06
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E7D2 RID: 124882
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7D3 RID: 124883 RVA: 0x002B3D14 File Offset: 0x002B1F14
		public string Get(vtkInformation info)
		{
			string s = Marshal.PtrToStringAnsi(vtkInformationStringKey.vtkInformationStringKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E7D4 RID: 124884
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationStringKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7D5 RID: 124885 RVA: 0x002B3D64 File Offset: 0x002B1F64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E7D6 RID: 124886
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationStringKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7D7 RID: 124887 RVA: 0x002B3D84 File Offset: 0x002B1F84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E7D8 RID: 124888
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationStringKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7D9 RID: 124889 RVA: 0x002B3DA0 File Offset: 0x002B1FA0
		public override int IsA(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E7DA RID: 124890
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationStringKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7DB RID: 124891 RVA: 0x002B3DC0 File Offset: 0x002B1FC0
		public new static int IsTypeOf(string type)
		{
			return vtkInformationStringKey.vtkInformationStringKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E7DC RID: 124892
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationStringKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E7DD RID: 124893 RVA: 0x002B3DDC File Offset: 0x002B1FDC
		public static vtkInformationStringKey MakeKey(string name, string location)
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringKey.vtkInformationStringKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601E7DE RID: 124894
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7DF RID: 124895 RVA: 0x002B3E48 File Offset: 0x002B2048
		public new vtkInformationStringKey NewInstance()
		{
			vtkInformationStringKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringKey.vtkInformationStringKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E7E0 RID: 124896
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7E1 RID: 124897 RVA: 0x002B3EA4 File Offset: 0x002B20A4
		public new static vtkInformationStringKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringKey.vtkInformationStringKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x0601E7E2 RID: 124898
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationStringKey_Set_09(HandleRef pThis, HandleRef info, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7E3 RID: 124899 RVA: 0x002B3F24 File Offset: 0x002B2124
		public void Set(vtkInformation info, string arg1)
		{
			vtkInformationStringKey.vtkInformationStringKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		// Token: 0x0601E7E4 RID: 124900
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationStringKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E7E5 RID: 124901 RVA: 0x002B3F54 File Offset: 0x002B2154
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationStringKey.vtkInformationStringKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AB RID: 8363
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationStringKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AC RID: 8364
		public new static readonly string MRClassNameKey = "class vtkInformationStringKey";
	}
}
