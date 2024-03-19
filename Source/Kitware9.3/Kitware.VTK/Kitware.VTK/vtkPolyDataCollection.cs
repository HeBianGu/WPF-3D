using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of polygonal data objects
	///
	/// vtkPolyDataCollection is an object that creates and manipulates ordered
	/// lists of datasets of type vtkPolyData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDataSetCollection vtkCollection
	/// </seealso>
	// Token: 0x02000AA1 RID: 2721
	public class vtkPolyDataCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601C933 RID: 117043 RVA: 0x00282316 File Offset: 0x00280516
		static vtkPolyDataCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601C934 RID: 117044 RVA: 0x0028233E File Offset: 0x0028053E
		public vtkPolyDataCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601C935 RID: 117045
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C936 RID: 117046 RVA: 0x0028234C File Offset: 0x0028054C
		public new static vtkPolyDataCollection New()
		{
			vtkPolyDataCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C937 RID: 117047 RVA: 0x002823A0 File Offset: 0x002805A0
		public vtkPolyDataCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataCollection.vtkPolyDataCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601C938 RID: 117048 RVA: 0x002823E4 File Offset: 0x002805E4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601C939 RID: 117049
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataCollection_AddItem_01(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Add a poly data to the bottom of the list.
		/// </summary>
		// Token: 0x0601C93A RID: 117050 RVA: 0x002823F0 File Offset: 0x002805F0
		public void AddItem(vtkPolyData pd)
		{
			vtkPolyDataCollection.vtkPolyDataCollection_AddItem_01(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x0601C93B RID: 117051
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next poly data in the list.
		/// </summary>
		// Token: 0x0601C93C RID: 117052 RVA: 0x00282420 File Offset: 0x00280620
		public vtkPolyData GetNextItem()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x0601C93D RID: 117053
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C93E RID: 117054 RVA: 0x00282490 File Offset: 0x00280690
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601C93F RID: 117055
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C940 RID: 117056 RVA: 0x002824B0 File Offset: 0x002806B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601C941 RID: 117057
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C942 RID: 117058 RVA: 0x002824CC File Offset: 0x002806CC
		public override int IsA(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601C943 RID: 117059
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C944 RID: 117060 RVA: 0x002824EC File Offset: 0x002806EC
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataCollection.vtkPolyDataCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601C945 RID: 117061
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C946 RID: 117062 RVA: 0x00282508 File Offset: 0x00280708
		public new vtkPolyDataCollection NewInstance()
		{
			vtkPolyDataCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601C947 RID: 117063
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601C948 RID: 117064 RVA: 0x00282564 File Offset: 0x00280764
		public new static vtkPolyDataCollection SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataCollection.vtkPolyDataCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E49 RID: 7753
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E4A RID: 7754
		public new static readonly string MRClassNameKey = "class vtkPolyDataCollection";
	}
}
