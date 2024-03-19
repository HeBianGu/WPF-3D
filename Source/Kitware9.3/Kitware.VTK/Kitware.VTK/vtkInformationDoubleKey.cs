using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationDoubleKey
	/// </summary>
	/// <remarks>
	///    Key for double values in vtkInformation.
	///
	/// vtkInformationDoubleKey is used to represent keys for double values
	/// in vtkInformation.
	/// </remarks>
	// Token: 0x02000B59 RID: 2905
	public class vtkInformationDoubleKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E66C RID: 124524 RVA: 0x002B1232 File Offset: 0x002AF432
		static vtkInformationDoubleKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationDoubleKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationDoubleKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E66D RID: 124525 RVA: 0x002B125A File Offset: 0x002AF45A
		public vtkInformationDoubleKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E66E RID: 124526 RVA: 0x002B1268 File Offset: 0x002AF468
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E66F RID: 124527
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInformationDoubleKey_Get_01(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E670 RID: 124528 RVA: 0x002B1274 File Offset: 0x002AF474
		public double Get(vtkInformation info)
		{
			return vtkInformationDoubleKey.vtkInformationDoubleKey_Get_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601E671 RID: 124529
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDoubleKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E672 RID: 124530 RVA: 0x002B12A8 File Offset: 0x002AF4A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationDoubleKey.vtkInformationDoubleKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E673 RID: 124531
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationDoubleKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E674 RID: 124532 RVA: 0x002B12C8 File Offset: 0x002AF4C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationDoubleKey.vtkInformationDoubleKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E675 RID: 124533
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDoubleKey_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E676 RID: 124534 RVA: 0x002B12E4 File Offset: 0x002AF4E4
		public override int IsA(string type)
		{
			return vtkInformationDoubleKey.vtkInformationDoubleKey_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E677 RID: 124535
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationDoubleKey_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E678 RID: 124536 RVA: 0x002B1304 File Offset: 0x002AF504
		public new static int IsTypeOf(string type)
		{
			return vtkInformationDoubleKey.vtkInformationDoubleKey_IsTypeOf_05(type);
		}

		// Token: 0x0601E679 RID: 124537
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleKey_MakeKey_06([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationDoubleKey, given a
		/// name and a location. This method is provided for wrappers. Use the
		/// constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601E67A RID: 124538 RVA: 0x002B1320 File Offset: 0x002AF520
		public static vtkInformationDoubleKey MakeKey(string name, string location)
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleKey.vtkInformationDoubleKey_MakeKey_06(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x0601E67B RID: 124539
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleKey_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E67C RID: 124540 RVA: 0x002B138C File Offset: 0x002AF58C
		public new vtkInformationDoubleKey NewInstance()
		{
			vtkInformationDoubleKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleKey.vtkInformationDoubleKey_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E67D RID: 124541
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationDoubleKey_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E67E RID: 124542 RVA: 0x002B13E8 File Offset: 0x002AF5E8
		public new static vtkInformationDoubleKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationDoubleKey vtkInformationDoubleKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationDoubleKey.vtkInformationDoubleKey_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationDoubleKey = (vtkInformationDoubleKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationDoubleKey.Register(null);
				}
			}
			return vtkInformationDoubleKey;
		}

		// Token: 0x0601E67F RID: 124543
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleKey_Set_09(HandleRef pThis, HandleRef info, double arg1);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601E680 RID: 124544 RVA: 0x002B1468 File Offset: 0x002AF668
		public void Set(vtkInformation info, double arg1)
		{
			vtkInformationDoubleKey.vtkInformationDoubleKey_Set_09(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), arg1);
		}

		// Token: 0x0601E681 RID: 124545
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationDoubleKey_ShallowCopy_10(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601E682 RID: 124546 RVA: 0x002B1498 File Offset: 0x002AF698
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationDoubleKey.vtkInformationDoubleKey_ShallowCopy_10(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002091 RID: 8337
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationDoubleKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002092 RID: 8338
		public new static readonly string MRClassNameKey = "class vtkInformationDoubleKey";
	}
}
