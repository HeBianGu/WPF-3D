using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationIterator
	/// </summary>
	/// <remarks>
	///    Iterates over keys of an information object
	///
	/// vtkInformationIterator can be used to iterate over the keys of an
	/// information object. The corresponding values can then be directly
	/// obtained from the information object using the keys.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInformation vtkInformationKey
	/// </seealso>
	// Token: 0x02000B60 RID: 2912
	public class vtkInformationIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E725 RID: 124709 RVA: 0x002B27E0 File Offset: 0x002B09E0
		static vtkInformationIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E726 RID: 124710 RVA: 0x002B2808 File Offset: 0x002B0A08
		public vtkInformationIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E727 RID: 124711
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E728 RID: 124712 RVA: 0x002B2818 File Offset: 0x002B0A18
		public new static vtkInformationIterator New()
		{
			vtkInformationIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E729 RID: 124713 RVA: 0x002B286C File Offset: 0x002B0A6C
		public vtkInformationIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInformationIterator.vtkInformationIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E72A RID: 124714 RVA: 0x002B28B0 File Offset: 0x002B0AB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E72B RID: 124715
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIterator_GetCurrentKey_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the current item. Valid only when IsDoneWithTraversal()
		/// returns 1.
		/// </summary>
		// Token: 0x0601E72C RID: 124716 RVA: 0x002B28BC File Offset: 0x002B0ABC
		public virtual vtkInformationKey GetCurrentKey()
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_GetCurrentKey_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E72D RID: 124717
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIterator_GetInformation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the information to iterator over.
		/// </summary>
		// Token: 0x0601E72E RID: 124718 RVA: 0x002B292C File Offset: 0x002B0B2C
		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_GetInformation_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0601E72F RID: 124719
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIterator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E730 RID: 124720 RVA: 0x002B299C File Offset: 0x002B0B9C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601E731 RID: 124721
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationIterator_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E732 RID: 124722 RVA: 0x002B29BC File Offset: 0x002B0BBC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601E733 RID: 124723
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIterator_GoToFirstItem_05(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the collection.
		/// </summary>
		// Token: 0x0601E734 RID: 124724 RVA: 0x002B29D6 File Offset: 0x002B0BD6
		public virtual void GoToFirstItem()
		{
			vtkInformationIterator.vtkInformationIterator_GoToFirstItem_05(base.GetCppThis());
		}

		// Token: 0x0601E735 RID: 124725
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIterator_GoToNextItem_06(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next item in the collection.
		/// </summary>
		// Token: 0x0601E736 RID: 124726 RVA: 0x002B29E5 File Offset: 0x002B0BE5
		public virtual void GoToNextItem()
		{
			vtkInformationIterator.vtkInformationIterator_GoToNextItem_06(base.GetCppThis());
		}

		// Token: 0x0601E737 RID: 124727
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIterator_InitTraversal_07(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the collection.
		/// </summary>
		// Token: 0x0601E738 RID: 124728 RVA: 0x002B29F4 File Offset: 0x002B0BF4
		public void InitTraversal()
		{
			vtkInformationIterator.vtkInformationIterator_InitTraversal_07(base.GetCppThis());
		}

		// Token: 0x0601E739 RID: 124729
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIterator_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E73A RID: 124730 RVA: 0x002B2A04 File Offset: 0x002B0C04
		public override int IsA(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601E73B RID: 124731
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIterator_IsDoneWithTraversal_09(HandleRef pThis);

		/// <summary>
		/// Test whether the iterator is currently pointing to a valid
		/// item. Returns 1 for yes, 0 for no.
		/// </summary>
		// Token: 0x0601E73C RID: 124732 RVA: 0x002B2A24 File Offset: 0x002B0C24
		public virtual int IsDoneWithTraversal()
		{
			return vtkInformationIterator.vtkInformationIterator_IsDoneWithTraversal_09(base.GetCppThis());
		}

		// Token: 0x0601E73D RID: 124733
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationIterator_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E73E RID: 124734 RVA: 0x002B2A44 File Offset: 0x002B0C44
		public new static int IsTypeOf(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_IsTypeOf_10(type);
		}

		// Token: 0x0601E73F RID: 124735
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIterator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E740 RID: 124736 RVA: 0x002B2A60 File Offset: 0x002B0C60
		public new vtkInformationIterator NewInstance()
		{
			vtkInformationIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E741 RID: 124737
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationIterator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E742 RID: 124738 RVA: 0x002B2ABC File Offset: 0x002B0CBC
		public new static vtkInformationIterator SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIterator vtkInformationIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIterator = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIterator.Register(null);
				}
			}
			return vtkInformationIterator;
		}

		// Token: 0x0601E743 RID: 124739
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIterator_SetInformation_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the information to iterator over.
		/// </summary>
		// Token: 0x0601E744 RID: 124740 RVA: 0x002B2B3C File Offset: 0x002B0D3C
		public void SetInformation(vtkInformation arg0)
		{
			vtkInformationIterator.vtkInformationIterator_SetInformation_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601E745 RID: 124741
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformationIterator_SetInformationWeak_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the function to iterate over. The iterator
		/// will not hold a reference to the information object.
		/// Can be used to optimize certain places by avoiding
		/// garbage collection.
		/// </summary>
		// Token: 0x0601E746 RID: 124742 RVA: 0x002B2B6C File Offset: 0x002B0D6C
		public void SetInformationWeak(vtkInformation arg0)
		{
			vtkInformationIterator.vtkInformationIterator_SetInformationWeak_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400209F RID: 8351
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A0 RID: 8352
		public new static readonly string MRClassNameKey = "class vtkInformationIterator";
	}
}
