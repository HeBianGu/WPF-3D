using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIdTypeKey
	/// </summary>
	/// <remarks>
	///    Key for vtkIdType values in vtkInformation.
	///
	/// vtkInformationIdTypeKey is used to represent keys for vtkIdType values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x02000B5B RID: 2907
	public class vtkInformationIdTypeKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E6A2 RID: 124578 RVA: 0x002B1858 File Offset: 0x002AFA58
		static vtkInformationIdTypeKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIdTypeKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIdTypeKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6A3 RID: 124579 RVA: 0x002B1880 File Offset: 0x002AFA80
		public vtkInformationIdTypeKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E6A4 RID: 124580 RVA: 0x002B188E File Offset: 0x002AFA8E
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E6A5 RID: 124581
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIdTypeKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6A6 RID: 124582 RVA: 0x002B189C File Offset: 0x002AFA9C
		public long Get(vtkInformation info)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E6A7 RID: 124583
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIdTypeKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6A8 RID: 124584 RVA: 0x002B18D0 File Offset: 0x002AFAD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E6A9 RID: 124585
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIdTypeKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6AA RID: 124586 RVA: 0x002B18F0 File Offset: 0x002AFAF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E6AB RID: 124587
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIdTypeKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6AC RID: 124588 RVA: 0x002B190C File Offset: 0x002AFB0C
		public override int IsA(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E6AD RID: 124589
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIdTypeKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6AE RID: 124590 RVA: 0x002B192C File Offset: 0x002AFB2C
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIdTypeKey.vtkInformationIdTypeKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E6AF RID: 124591
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIdTypeKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationIdTypeKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E6B0 RID: 124592 RVA: 0x002B1948 File Offset: 0x002AFB48
		public static vtkInformationIdTypeKey MakeKey(string name, string location)
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIdTypeKey.vtkInformationIdTypeKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		// Token: 0x0601E6B1 RID: 124593
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIdTypeKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6B2 RID: 124594 RVA: 0x002B19B4 File Offset: 0x002AFBB4
		public new vtkInformationIdTypeKey NewInstance()
		{
			vtkInformationIdTypeKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIdTypeKey.vtkInformationIdTypeKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E6B3 RID: 124595
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIdTypeKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E6B4 RID: 124596 RVA: 0x002B1A10 File Offset: 0x002AFC10
		public new static vtkInformationIdTypeKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIdTypeKey vtkInformationIdTypeKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIdTypeKey.vtkInformationIdTypeKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIdTypeKey = (vtkInformationIdTypeKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIdTypeKey.Register(null);
				}
			}
			return vtkInformationIdTypeKey;
		}

		// Token: 0x0601E6B5 RID: 124597
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIdTypeKey_Set_09(HandleRef pThis, HandleRef info, long arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E6B6 RID: 124598 RVA: 0x002B1A90 File Offset: 0x002AFC90
		public void Set(vtkInformation info, long arg1)
		{
			vtkInformationIdTypeKey.vtkInformationIdTypeKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		// Token: 0x0601E6B7 RID: 124599
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIdTypeKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E6B8 RID: 124600 RVA: 0x002B1AC0 File Offset: 0x002AFCC0
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationIdTypeKey.vtkInformationIdTypeKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002095 RID: 8341
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIdTypeKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002096 RID: 8342
		public new static readonly string MRClassNameKey = "class vtkInformationIdTypeKey";
	}
}
