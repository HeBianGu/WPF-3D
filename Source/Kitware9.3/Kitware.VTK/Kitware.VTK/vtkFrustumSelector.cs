using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFrustumSelector
	///
	/// vtkFrustumSelector is a vtkSelector that selects elements based
	/// on whether they are inside or intersect a frustum of interest.  This handles
	/// the vtkSelectionNode::FRUSTUM selection type.
	///
	/// </summary>
	// Token: 0x020006BE RID: 1726
	public class vtkFrustumSelector : vtkSelector
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060126E9 RID: 75497 RVA: 0x0019CFC7 File Offset: 0x0019B1C7
		static vtkFrustumSelector()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFrustumSelector.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFrustumSelector"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060126EA RID: 75498 RVA: 0x0019CFEF File Offset: 0x0019B1EF
		public vtkFrustumSelector(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060126EB RID: 75499
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSelector_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126EC RID: 75500 RVA: 0x0019D000 File Offset: 0x0019B200
		public new static vtkFrustumSelector New()
		{
			vtkFrustumSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSelector.vtkFrustumSelector_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126ED RID: 75501 RVA: 0x0019D054 File Offset: 0x0019B254
		public vtkFrustumSelector() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFrustumSelector.vtkFrustumSelector_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060126EE RID: 75502 RVA: 0x0019D098 File Offset: 0x0019B298
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060126EF RID: 75503
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSelector_GetFrustum_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the selection frustum. The planes object must contain six planes.
		/// </summary>
		// Token: 0x060126F0 RID: 75504 RVA: 0x0019D0A4 File Offset: 0x0019B2A4
		public vtkPlanes GetFrustum()
		{
			vtkPlanes vtkPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSelector.vtkFrustumSelector_GetFrustum_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlanes = (vtkPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlanes.Register(null);
				}
			}
			return vtkPlanes;
		}

		// Token: 0x060126F1 RID: 75505
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkFrustumSelector_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Return the MTime taking into account changes to the Frustum
		/// </summary>
		// Token: 0x060126F2 RID: 75506 RVA: 0x0019D114 File Offset: 0x0019B314
		public override ulong GetMTime()
		{
			return vtkFrustumSelector.vtkFrustumSelector_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x060126F3 RID: 75507
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumSelector_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126F4 RID: 75508 RVA: 0x0019D134 File Offset: 0x0019B334
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFrustumSelector.vtkFrustumSelector_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060126F5 RID: 75509
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFrustumSelector_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126F6 RID: 75510 RVA: 0x0019D154 File Offset: 0x0019B354
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFrustumSelector.vtkFrustumSelector_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060126F7 RID: 75511
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSelector_Initialize_05(HandleRef pThis, HandleRef node);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126F8 RID: 75512 RVA: 0x0019D170 File Offset: 0x0019B370
		public override void Initialize(vtkSelectionNode node)
		{
			vtkFrustumSelector.vtkFrustumSelector_Initialize_05(base.GetCppThis(), (node == null) ? default(HandleRef) : node.GetCppThis());
		}

		// Token: 0x060126F9 RID: 75513
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumSelector_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126FA RID: 75514 RVA: 0x0019D1A0 File Offset: 0x0019B3A0
		public override int IsA(string type)
		{
			return vtkFrustumSelector.vtkFrustumSelector_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060126FB RID: 75515
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFrustumSelector_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126FC RID: 75516 RVA: 0x0019D1C0 File Offset: 0x0019B3C0
		public new static int IsTypeOf(string type)
		{
			return vtkFrustumSelector.vtkFrustumSelector_IsTypeOf_07(type);
		}

		// Token: 0x060126FD RID: 75517
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSelector_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060126FE RID: 75518 RVA: 0x0019D1DC File Offset: 0x0019B3DC
		public new vtkFrustumSelector NewInstance()
		{
			vtkFrustumSelector result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSelector.vtkFrustumSelector_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFrustumSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060126FF RID: 75519
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFrustumSelector_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012700 RID: 75520 RVA: 0x0019D238 File Offset: 0x0019B438
		public new static vtkFrustumSelector SafeDownCast(vtkObjectBase o)
		{
			vtkFrustumSelector vtkFrustumSelector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFrustumSelector.vtkFrustumSelector_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFrustumSelector = (vtkFrustumSelector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFrustumSelector.Register(null);
				}
			}
			return vtkFrustumSelector;
		}

		// Token: 0x06012701 RID: 75521
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFrustumSelector_SetFrustum_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the selection frustum. The planes object must contain six planes.
		/// </summary>
		// Token: 0x06012702 RID: 75522 RVA: 0x0019D2B8 File Offset: 0x0019B4B8
		public void SetFrustum(vtkPlanes arg0)
		{
			vtkFrustumSelector.vtkFrustumSelector_SetFrustum_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152C RID: 5420
		public new const string MRFullTypeName = "Kitware.VTK.vtkFrustumSelector";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400152D RID: 5421
		public new static readonly string MRClassNameKey = "class vtkFrustumSelector";
	}
}
