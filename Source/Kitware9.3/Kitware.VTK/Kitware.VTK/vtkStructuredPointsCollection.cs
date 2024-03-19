using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredPointsCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of structured points data objects
	///
	/// vtkStructuredPointsCollection is an object that creates and manipulates
	/// ordered lists of structured points datasets. See also vtkCollection and
	/// subclasses.
	/// </remarks>
	// Token: 0x02000AD0 RID: 2768
	public class vtkStructuredPointsCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D243 RID: 119363 RVA: 0x0029155B File Offset: 0x0028F75B
		static vtkStructuredPointsCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPointsCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPointsCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D244 RID: 119364 RVA: 0x00291583 File Offset: 0x0028F783
		public vtkStructuredPointsCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D245 RID: 119365
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D246 RID: 119366 RVA: 0x00291594 File Offset: 0x0028F794
		public new static vtkStructuredPointsCollection New()
		{
			vtkStructuredPointsCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsCollection.vtkStructuredPointsCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D247 RID: 119367 RVA: 0x002915E8 File Offset: 0x0028F7E8
		public vtkStructuredPointsCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredPointsCollection.vtkStructuredPointsCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D248 RID: 119368 RVA: 0x0029162C File Offset: 0x0028F82C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D249 RID: 119369
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredPointsCollection_AddItem_01(HandleRef pThis, HandleRef ds);

		/// <summary>
		/// Add a pointer to a vtkStructuredPoints to the bottom of the list.
		/// </summary>
		// Token: 0x0601D24A RID: 119370 RVA: 0x00291638 File Offset: 0x0028F838
		public void AddItem(vtkStructuredPoints ds)
		{
			vtkStructuredPointsCollection.vtkStructuredPointsCollection_AddItem_01(base.GetCppThis(), (ds == null) ? default(HandleRef) : ds.GetCppThis());
		}

		// Token: 0x0601D24B RID: 119371
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next item in the collection. nullptr is returned if the collection
		/// is exhausted.
		/// </summary>
		// Token: 0x0601D24C RID: 119372 RVA: 0x00291668 File Offset: 0x0028F868
		public vtkStructuredPoints GetNextItem()
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsCollection.vtkStructuredPointsCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		// Token: 0x0601D24D RID: 119373
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D24E RID: 119374 RVA: 0x002916D8 File Offset: 0x0028F8D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredPointsCollection.vtkStructuredPointsCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D24F RID: 119375
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPointsCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D250 RID: 119376 RVA: 0x002916F8 File Offset: 0x0028F8F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredPointsCollection.vtkStructuredPointsCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D251 RID: 119377
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D252 RID: 119378 RVA: 0x00291714 File Offset: 0x0028F914
		public override int IsA(string type)
		{
			return vtkStructuredPointsCollection.vtkStructuredPointsCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D253 RID: 119379
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPointsCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D254 RID: 119380 RVA: 0x00291734 File Offset: 0x0028F934
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPointsCollection.vtkStructuredPointsCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601D255 RID: 119381
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D256 RID: 119382 RVA: 0x00291750 File Offset: 0x0028F950
		public new vtkStructuredPointsCollection NewInstance()
		{
			vtkStructuredPointsCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsCollection.vtkStructuredPointsCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPointsCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D257 RID: 119383
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPointsCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D258 RID: 119384 RVA: 0x002917AC File Offset: 0x0028F9AC
		public new static vtkStructuredPointsCollection SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPointsCollection vtkStructuredPointsCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPointsCollection.vtkStructuredPointsCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPointsCollection = (vtkStructuredPointsCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPointsCollection.Register(null);
				}
			}
			return vtkStructuredPointsCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC6 RID: 7878
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPointsCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC7 RID: 7879
		public new static readonly string MRClassNameKey = "class vtkStructuredPointsCollection";
	}
}
