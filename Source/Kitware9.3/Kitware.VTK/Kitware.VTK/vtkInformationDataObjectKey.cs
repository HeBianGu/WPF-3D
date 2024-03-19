using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationDataObjectKey
	/// </summary>
	/// <remarks>
	///    Key for vtkDataObject values.
	///
	/// vtkInformationDataObjectKey is used to represent keys in
	/// vtkInformation for values that are vtkDataObject instances.
	/// </remarks>
	// Token: 0x020009D8 RID: 2520
	public class vtkInformationDataObjectKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A40E RID: 107534 RVA: 0x00246A2D File Offset: 0x00244C2D
		static vtkInformationDataObjectKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDataObjectKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDataObjectKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A40F RID: 107535 RVA: 0x00246A55 File Offset: 0x00244C55
		public vtkInformationDataObjectKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A410 RID: 107536 RVA: 0x00246A63 File Offset: 0x00244C63
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A411 RID: 107537
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectKey_Get_01(HandleRef pThis, HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A412 RID: 107538 RVA: 0x00246A70 File Offset: 0x00244C70
		public vtkDataObject Get(vtkInformation info)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601A413 RID: 107539
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDataObjectKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A414 RID: 107540 RVA: 0x00246AF8 File Offset: 0x00244CF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A415 RID: 107541
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDataObjectKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A416 RID: 107542 RVA: 0x00246B18 File Offset: 0x00244D18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A417 RID: 107543
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDataObjectKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A418 RID: 107544 RVA: 0x00246B34 File Offset: 0x00244D34
		public override int IsA(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A419 RID: 107545
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDataObjectKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A41A RID: 107546 RVA: 0x00246B54 File Offset: 0x00244D54
		public new static int IsTypeOf(string type)
		{
			return vtkInformationDataObjectKey.vtkInformationDataObjectKey_IsTypeOf_05(type);
		}

		// Token: 0x0601A41B RID: 107547
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationDataObjectKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A41C RID: 107548 RVA: 0x00246B70 File Offset: 0x00244D70
		public static vtkInformationDataObjectKey MakeKey(string name, string location)
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x0601A41D RID: 107549
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A41E RID: 107550 RVA: 0x00246BDC File Offset: 0x00244DDC
		public new vtkInformationDataObjectKey NewInstance()
		{
			vtkInformationDataObjectKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A41F RID: 107551
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDataObjectKey_Report_08(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601A420 RID: 107552 RVA: 0x00246C38 File Offset: 0x00244E38
		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_Report_08(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601A421 RID: 107553
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDataObjectKey_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A422 RID: 107554 RVA: 0x00246C7C File Offset: 0x00244E7C
		public new static vtkInformationDataObjectKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDataObjectKey vtkInformationDataObjectKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDataObjectKey.vtkInformationDataObjectKey_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDataObjectKey = (vtkInformationDataObjectKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDataObjectKey.Register(null);
				}
			}
			return vtkInformationDataObjectKey;
		}

		// Token: 0x0601A423 RID: 107555
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDataObjectKey_Set_10(HandleRef pThis, HandleRef info, HandleRef arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A424 RID: 107556 RVA: 0x00246CFC File Offset: 0x00244EFC
		public void Set(vtkInformation info, vtkDataObject arg1)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_Set_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601A425 RID: 107557
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDataObjectKey_ShallowCopy_11(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601A426 RID: 107558 RVA: 0x00246D40 File Offset: 0x00244F40
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationDataObjectKey.vtkInformationDataObjectKey_ShallowCopy_11(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C80 RID: 7296
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDataObjectKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C81 RID: 7297
		public new static readonly string MRClassNameKey = "class vtkInformationDataObjectKey";
	}
}
