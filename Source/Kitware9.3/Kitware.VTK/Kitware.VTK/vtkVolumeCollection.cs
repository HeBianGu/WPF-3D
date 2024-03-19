using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of volumes
	///
	/// vtkVolumeCollection represents and provides methods to manipulate a
	/// list of volumes (i.e., vtkVolume and subclasses). The list is ordered
	/// and duplicate entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkVolume
	/// </seealso>
	// Token: 0x02000808 RID: 2056
	public class vtkVolumeCollection : vtkPropCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060151A8 RID: 86440 RVA: 0x001DDEAB File Offset: 0x001DC0AB
		static vtkVolumeCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060151A9 RID: 86441 RVA: 0x001DDED3 File Offset: 0x001DC0D3
		public vtkVolumeCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060151AA RID: 86442
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151AB RID: 86443 RVA: 0x001DDEE4 File Offset: 0x001DC0E4
		public new static vtkVolumeCollection New()
		{
			vtkVolumeCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeCollection.vtkVolumeCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151AC RID: 86444 RVA: 0x001DDF38 File Offset: 0x001DC138
		public vtkVolumeCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeCollection.vtkVolumeCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060151AD RID: 86445 RVA: 0x001DDF7C File Offset: 0x001DC17C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060151AE RID: 86446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a Volume to the bottom of the list.
		/// </summary>
		// Token: 0x060151AF RID: 86447 RVA: 0x001DDF88 File Offset: 0x001DC188
		public void AddItem(vtkVolume a)
		{
			vtkVolumeCollection.vtkVolumeCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060151B0 RID: 86448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Access routine provided for compatibility with previous
		/// versions of VTK.  Please use the GetNextVolume() variant
		/// where possible.
		/// </summary>
		// Token: 0x060151B1 RID: 86449 RVA: 0x001DDFB8 File Offset: 0x001DC1B8
		public vtkVolume GetNextItem()
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeCollection.vtkVolumeCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x060151B2 RID: 86450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeCollection_GetNextVolume_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next Volume in the list. Return NULL when at the end of the
		/// list.
		/// </summary>
		// Token: 0x060151B3 RID: 86451 RVA: 0x001DE028 File Offset: 0x001DC228
		public vtkVolume GetNextVolume()
		{
			vtkVolume vtkVolume = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeCollection.vtkVolumeCollection_GetNextVolume_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume = (vtkVolume)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume.Register(null);
				}
			}
			return vtkVolume;
		}

		// Token: 0x060151B4 RID: 86452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151B5 RID: 86453 RVA: 0x001DE098 File Offset: 0x001DC298
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeCollection.vtkVolumeCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060151B6 RID: 86454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151B7 RID: 86455 RVA: 0x001DE0B8 File Offset: 0x001DC2B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeCollection.vtkVolumeCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060151B8 RID: 86456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151B9 RID: 86457 RVA: 0x001DE0D4 File Offset: 0x001DC2D4
		public override int IsA(string type)
		{
			return vtkVolumeCollection.vtkVolumeCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060151BA RID: 86458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151BB RID: 86459 RVA: 0x001DE0F4 File Offset: 0x001DC2F4
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeCollection.vtkVolumeCollection_IsTypeOf_07(type);
		}

		// Token: 0x060151BC RID: 86460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151BD RID: 86461 RVA: 0x001DE110 File Offset: 0x001DC310
		public new vtkVolumeCollection NewInstance()
		{
			vtkVolumeCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeCollection.vtkVolumeCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060151BE RID: 86462
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060151BF RID: 86463 RVA: 0x001DE16C File Offset: 0x001DC36C
		public new static vtkVolumeCollection SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeCollection vtkVolumeCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeCollection.vtkVolumeCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeCollection = (vtkVolumeCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeCollection.Register(null);
				}
			}
			return vtkVolumeCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001857 RID: 6231
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001858 RID: 6232
		public new static readonly string MRClassNameKey = "class vtkVolumeCollection";
	}
}
