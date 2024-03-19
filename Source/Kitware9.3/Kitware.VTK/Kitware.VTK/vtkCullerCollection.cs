using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCullerCollection
	/// </summary>
	/// <remarks>
	///    an ordered list of Cullers
	///
	/// vtkCullerCollection represents and provides methods to manipulate a list
	/// of Cullers (i.e., vtkCuller and subclasses). The list is ordered and
	/// duplicate entries are not prevented.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCuller vtkCollection
	/// </seealso>
	// Token: 0x020007D8 RID: 2008
	public class vtkCullerCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060149D6 RID: 84438 RVA: 0x001D2EDF File Offset: 0x001D10DF
		static vtkCullerCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCullerCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCullerCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060149D7 RID: 84439 RVA: 0x001D2F07 File Offset: 0x001D1107
		public vtkCullerCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060149D8 RID: 84440
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCullerCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149D9 RID: 84441 RVA: 0x001D2F18 File Offset: 0x001D1118
		public new static vtkCullerCollection New()
		{
			vtkCullerCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149DA RID: 84442 RVA: 0x001D2F6C File Offset: 0x001D116C
		public vtkCullerCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCullerCollection.vtkCullerCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060149DB RID: 84443 RVA: 0x001D2FB0 File Offset: 0x001D11B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060149DC RID: 84444
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCullerCollection_AddItem_01(HandleRef pThis, HandleRef a);

		/// <summary>
		/// Add an Culler to the bottom of the list.
		/// </summary>
		// Token: 0x060149DD RID: 84445 RVA: 0x001D2FBC File Offset: 0x001D11BC
		public void AddItem(vtkCuller a)
		{
			vtkCullerCollection.vtkCullerCollection_AddItem_01(base.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis());
		}

		// Token: 0x060149DE RID: 84446
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCullerCollection_GetLastItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the last Culler in the list.
		/// </summary>
		// Token: 0x060149DF RID: 84447 RVA: 0x001D2FEC File Offset: 0x001D11EC
		public vtkCuller GetLastItem()
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_GetLastItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}

		// Token: 0x060149E0 RID: 84448
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCullerCollection_GetNextItem_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next Culler in the list.
		/// </summary>
		// Token: 0x060149E1 RID: 84449 RVA: 0x001D305C File Offset: 0x001D125C
		public vtkCuller GetNextItem()
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_GetNextItem_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}

		// Token: 0x060149E2 RID: 84450
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCullerCollection_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149E3 RID: 84451 RVA: 0x001D30CC File Offset: 0x001D12CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060149E4 RID: 84452
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCullerCollection_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149E5 RID: 84453 RVA: 0x001D30EC File Offset: 0x001D12EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060149E6 RID: 84454
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCullerCollection_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149E7 RID: 84455 RVA: 0x001D3108 File Offset: 0x001D1308
		public override int IsA(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060149E8 RID: 84456
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCullerCollection_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149E9 RID: 84457 RVA: 0x001D3128 File Offset: 0x001D1328
		public new static int IsTypeOf(string type)
		{
			return vtkCullerCollection.vtkCullerCollection_IsTypeOf_07(type);
		}

		// Token: 0x060149EA RID: 84458
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCullerCollection_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149EB RID: 84459 RVA: 0x001D3144 File Offset: 0x001D1344
		public new vtkCullerCollection NewInstance()
		{
			vtkCullerCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060149EC RID: 84460
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCullerCollection_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060149ED RID: 84461 RVA: 0x001D31A0 File Offset: 0x001D13A0
		public new static vtkCullerCollection SafeDownCast(vtkObjectBase o)
		{
			vtkCullerCollection vtkCullerCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCullerCollection.vtkCullerCollection_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCullerCollection = (vtkCullerCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCullerCollection.Register(null);
				}
			}
			return vtkCullerCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D6 RID: 6102
		public new const string MRFullTypeName = "Kitware.VTK.vtkCullerCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040017D7 RID: 6103
		public new static readonly string MRClassNameKey = "class vtkCullerCollection";
	}
}
