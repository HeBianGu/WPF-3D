using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationStringVectorKey
	/// </summary>
	/// <remarks>
	///    Key for String vector values.
	///
	/// vtkInformationStringVectorKey is used to represent keys for String
	/// vector values in vtkInformation.h
	/// </remarks>
	// Token: 0x02000B67 RID: 2919
	public class vtkInformationStringVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E7E6 RID: 124902 RVA: 0x002B3F98 File Offset: 0x002B2198
		static vtkInformationStringVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationStringVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationStringVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7E7 RID: 124903 RVA: 0x002B3FC0 File Offset: 0x002B21C0
		public vtkInformationStringVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E7E8 RID: 124904 RVA: 0x002B3FCE File Offset: 0x002B21CE
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E7E9 RID: 124905
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationStringVectorKey_Append_01(HandleRef pThis, HandleRef info, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7EA RID: 124906 RVA: 0x002B3FDC File Offset: 0x002B21DC
		public void Append(vtkInformation info, string value)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value);
		}

		// Token: 0x0601E7EB RID: 124907
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringVectorKey_Get_02(HandleRef pThis, HandleRef info, int idx);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7EC RID: 124908 RVA: 0x002B400C File Offset: 0x002B220C
		public string Get(vtkInformation info, int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkInformationStringVectorKey.vtkInformationStringVectorKey_Get_02(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E7ED RID: 124909
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationStringVectorKey_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7EE RID: 124910 RVA: 0x002B405C File Offset: 0x002B225C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E7EF RID: 124911
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationStringVectorKey_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7F0 RID: 124912 RVA: 0x002B407C File Offset: 0x002B227C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E7F1 RID: 124913
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationStringVectorKey_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7F2 RID: 124914 RVA: 0x002B4098 File Offset: 0x002B2298
		public override int IsA(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601E7F3 RID: 124915
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationStringVectorKey_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7F4 RID: 124916 RVA: 0x002B40B8 File Offset: 0x002B22B8
		public new static int IsTypeOf(string type)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_IsTypeOf_06(type);
		}

		// Token: 0x0601E7F5 RID: 124917
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationStringVectorKey_Length_07(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7F6 RID: 124918 RVA: 0x002B40D4 File Offset: 0x002B22D4
		public int Length(vtkInformation info)
		{
			return vtkInformationStringVectorKey.vtkInformationStringVectorKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E7F7 RID: 124919
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringVectorKey_MakeKey_08([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, int length, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationStringVectorKey, given a
		/// name, a location and a required length. This method is provided for
		/// wrappers. Use the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E7F8 RID: 124920 RVA: 0x002B4108 File Offset: 0x002B2308
		public static vtkInformationStringVectorKey MakeKey(string name, string location, int length)
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringVectorKey.vtkInformationStringVectorKey_MakeKey_08(name, location, length, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		// Token: 0x0601E7F9 RID: 124921
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringVectorKey_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7FA RID: 124922 RVA: 0x002B4174 File Offset: 0x002B2374
		public new vtkInformationStringVectorKey NewInstance()
		{
			vtkInformationStringVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringVectorKey.vtkInformationStringVectorKey_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E7FB RID: 124923
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationStringVectorKey_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E7FC RID: 124924 RVA: 0x002B41D0 File Offset: 0x002B23D0
		public new static vtkInformationStringVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationStringVectorKey vtkInformationStringVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationStringVectorKey.vtkInformationStringVectorKey_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringVectorKey = (vtkInformationStringVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringVectorKey.Register(null);
				}
			}
			return vtkInformationStringVectorKey;
		}

		// Token: 0x0601E7FD RID: 124925
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationStringVectorKey_Set_11(HandleRef pThis, HandleRef info, [MarshalAs(UnmanagedType.LPUTF8Str)] string value, int index);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E7FE RID: 124926 RVA: 0x002B4250 File Offset: 0x002B2450
		public void Set(vtkInformation info, string value, int index)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_Set_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), value, index);
		}

		// Token: 0x0601E7FF RID: 124927
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationStringVectorKey_ShallowCopy_12(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E800 RID: 124928 RVA: 0x002B4284 File Offset: 0x002B2484
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationStringVectorKey.vtkInformationStringVectorKey_ShallowCopy_12(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AD RID: 8365
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationStringVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020AE RID: 8366
		public new static readonly string MRClassNameKey = "class vtkInformationStringVectorKey";
	}
}
