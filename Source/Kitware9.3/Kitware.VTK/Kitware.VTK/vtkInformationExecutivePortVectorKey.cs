using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationExecutivePortVectorKey
	/// </summary>
	/// <remarks>
	///    Key for vtkExecutive/Port value pair vectors.
	///
	/// vtkInformationExecutivePortVectorKey is used to represent keys in
	/// vtkInformation for values that are vectors of vtkExecutive
	/// instances paired with port numbers.
	/// </remarks>
	// Token: 0x020009DB RID: 2523
	public class vtkInformationExecutivePortVectorKey : vtkInformationKey
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A457 RID: 107607 RVA: 0x002473B8 File Offset: 0x002455B8
		static vtkInformationExecutivePortVectorKey()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationExecutivePortVectorKey.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationExecutivePortVectorKey"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A458 RID: 107608 RVA: 0x002473E0 File Offset: 0x002455E0
		public vtkInformationExecutivePortVectorKey(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A459 RID: 107609 RVA: 0x002473EE File Offset: 0x002455EE
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A45A RID: 107610
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortVectorKey_Append_01(HandleRef pThis, HandleRef info, HandleRef executive, int port);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A45B RID: 107611 RVA: 0x002473FC File Offset: 0x002455FC
		public void Append(vtkInformation info, vtkExecutive executive, int port)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Append_01(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), port);
		}

		// Token: 0x0601A45C RID: 107612
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationExecutivePortVectorKey_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A45D RID: 107613 RVA: 0x00247444 File Offset: 0x00245644
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601A45E RID: 107614
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationExecutivePortVectorKey_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A45F RID: 107615 RVA: 0x00247464 File Offset: 0x00245664
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601A460 RID: 107616
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_GetPorts_04(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A461 RID: 107617 RVA: 0x00247480 File Offset: 0x00245680
		public IntPtr GetPorts(vtkInformation info)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_GetPorts_04(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A462 RID: 107618
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortVectorKey_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A463 RID: 107619 RVA: 0x002474B4 File Offset: 0x002456B4
		public override int IsA(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601A464 RID: 107620
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortVectorKey_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A465 RID: 107621 RVA: 0x002474D4 File Offset: 0x002456D4
		public new static int IsTypeOf(string type)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_IsTypeOf_06(type);
		}

		// Token: 0x0601A466 RID: 107622
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationExecutivePortVectorKey_Length_07(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A467 RID: 107623 RVA: 0x002474F0 File Offset: 0x002456F0
		public int Length(vtkInformation info)
		{
			return vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Length_07(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A468 RID: 107624
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_MakeKey_08([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// This method simply returns a new vtkInformationExecutivePortVectorKey,
		/// given a name and a location. This method is provided for wrappers. Use
		/// the constructor directly from C++ instead.
		/// </summary>
		// Token: 0x0601A469 RID: 107625 RVA: 0x00247524 File Offset: 0x00245724
		public static vtkInformationExecutivePortVectorKey MakeKey(string name, string location)
		{
			vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_MakeKey_08(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortVectorKey = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortVectorKey.Register(null);
				}
			}
			return vtkInformationExecutivePortVectorKey;
		}

		// Token: 0x0601A46A RID: 107626
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A46B RID: 107627 RVA: 0x00247590 File Offset: 0x00245790
		public new vtkInformationExecutivePortVectorKey NewInstance()
		{
			vtkInformationExecutivePortVectorKey result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A46C RID: 107628
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortVectorKey_Remove_10(HandleRef pThis, HandleRef info, HandleRef executive, int port);

		/// <summary>
		/// Get/Set the value associated with this key in the given
		/// information object.
		/// </summary>
		// Token: 0x0601A46D RID: 107629 RVA: 0x002475EC File Offset: 0x002457EC
		public void Remove(vtkInformation info, vtkExecutive executive, int port)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Remove_10(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (executive == null) ? default(HandleRef) : executive.GetCppThis(), port);
		}

		// Token: 0x0601A46E RID: 107630
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortVectorKey_Remove_11(HandleRef pThis, HandleRef info);

		/// <summary>
		/// Remove this key from the given information object.
		/// </summary>
		// Token: 0x0601A46F RID: 107631 RVA: 0x00247634 File Offset: 0x00245834
		public override void Remove(vtkInformation info)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Remove_11(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		// Token: 0x0601A470 RID: 107632
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortVectorKey_Report_12(HandleRef pThis, HandleRef info, HandleRef collector);

		/// <summary>
		/// Report a reference this key has in the given information object.
		/// </summary>
		// Token: 0x0601A471 RID: 107633 RVA: 0x00247664 File Offset: 0x00245864
		public override void Report(vtkInformation info, vtkGarbageCollector collector)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_Report_12(base.GetCppThis(), (info == null) ? default(HandleRef) : info.GetCppThis(), (collector == null) ? default(HandleRef) : collector.GetCppThis());
		}

		// Token: 0x0601A472 RID: 107634
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationExecutivePortVectorKey_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A473 RID: 107635 RVA: 0x002476A8 File Offset: 0x002458A8
		public new static vtkInformationExecutivePortVectorKey SafeDownCast(vtkObjectBase o)
		{
			vtkInformationExecutivePortVectorKey vtkInformationExecutivePortVectorKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationExecutivePortVectorKey = (vtkInformationExecutivePortVectorKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationExecutivePortVectorKey.Register(null);
				}
			}
			return vtkInformationExecutivePortVectorKey;
		}

		// Token: 0x0601A474 RID: 107636
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationExecutivePortVectorKey_ShallowCopy_14(HandleRef pThis, HandleRef from, HandleRef to);

		/// <summary>
		/// Copy the entry associated with this key from one information
		/// object to another.  If there is no entry in the first information
		/// object for this key, the value is removed from the second.
		/// </summary>
		// Token: 0x0601A475 RID: 107637 RVA: 0x00247728 File Offset: 0x00245928
		public override void ShallowCopy(vtkInformation from, vtkInformation to)
		{
			vtkInformationExecutivePortVectorKey.vtkInformationExecutivePortVectorKey_ShallowCopy_14(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (to == null) ? default(HandleRef) : to.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C86 RID: 7302
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationExecutivePortVectorKey";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C87 RID: 7303
		public new static readonly string MRClassNameKey = "class vtkInformationExecutivePortVectorKey";
	}
}
