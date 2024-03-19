using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLightCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of lights
	///
	/// vtkLightCollection represents and provides methods to manipulate a list of
	/// lights (i.e., vtkLight and subclasses). The list is ordered and duplicate
	/// entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection vtkLight
	/// </seealso>
	// Token: 0x020007ED RID: 2029
	public class vtkLightCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014DD8 RID: 85464 RVA: 0x001D84A7 File Offset: 0x001D66A7
		static vtkLightCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLightCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLightCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014DD9 RID: 85465 RVA: 0x001D84CF File Offset: 0x001D66CF
		public vtkLightCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014DDA RID: 85466
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DDB RID: 85467 RVA: 0x001D84E0 File Offset: 0x001D66E0
		public new static vtkLightCollection New()
		{
			vtkLightCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightCollection.vtkLightCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DDC RID: 85468 RVA: 0x001D8534 File Offset: 0x001D6734
		public vtkLightCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLightCollection.vtkLightCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014DDD RID: 85469 RVA: 0x001D8578 File Offset: 0x001D6778
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014DDE RID: 85470
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLightCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add a light to the bottom of the list.
		/// </summary>
		// Token: 0x06014DDF RID: 85471 RVA: 0x001D8584 File Offset: 0x001D6784
		public void AddItem(vtkLight a)
		{
			vtkLightCollection.vtkLightCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x06014DE0 RID: 85472
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next light in the list. NULL is returned when the collection is
		/// exhausted.
		/// </summary>
		// Token: 0x06014DE1 RID: 85473 RVA: 0x001D85B4 File Offset: 0x001D67B4
		public vtkLight GetNextItem()
		{
			vtkLight vtkLight = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightCollection.vtkLightCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLight = (vtkLight)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLight.Register(null);
				}
			}
			return vtkLight;
		}

		// Token: 0x06014DE2 RID: 85474
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DE3 RID: 85475 RVA: 0x001D8624 File Offset: 0x001D6824
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLightCollection.vtkLightCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06014DE4 RID: 85476
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLightCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DE5 RID: 85477 RVA: 0x001D8644 File Offset: 0x001D6844
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLightCollection.vtkLightCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06014DE6 RID: 85478
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DE7 RID: 85479 RVA: 0x001D8660 File Offset: 0x001D6860
		public override int IsA(string type)
		{
			return vtkLightCollection.vtkLightCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06014DE8 RID: 85480
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLightCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DE9 RID: 85481 RVA: 0x001D8680 File Offset: 0x001D6880
		public new static int IsTypeOf(string type)
		{
			return vtkLightCollection.vtkLightCollection_IsTypeOf_06(type);
		}

		// Token: 0x06014DEA RID: 85482
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DEB RID: 85483 RVA: 0x001D869C File Offset: 0x001D689C
		public new vtkLightCollection NewInstance()
		{
			vtkLightCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightCollection.vtkLightCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014DEC RID: 85484
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLightCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014DED RID: 85485 RVA: 0x001D86F8 File Offset: 0x001D68F8
		public new static vtkLightCollection SafeDownCast(vtkObjectBase o)
		{
			vtkLightCollection vtkLightCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLightCollection.vtkLightCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLightCollection = (vtkLightCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLightCollection.Register(null);
				}
			}
			return vtkLightCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001810 RID: 6160
		public new const string MRFullTypeName = "Kitware.VTK.vtkLightCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001811 RID: 6161
		public new static readonly string MRClassNameKey = "class vtkLightCollection";
	}
}
