using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkPartitionedDataSetCollectionSource
	/// </summary>
	/// <remarks>
	///  a source that produces a vtkPartitionedDataSetCollection.
	///
	/// vtkPartitionedDataSetCollection generates a vtkPartitionedDataSetCollection
	/// for testing purposes. It uses vtkParametricFunctionSource internally to
	/// generate different types of surfaces for each partitioned dataset in the
	/// collection. Each partitioned dataset is split among ranks in an even fashion.
	/// Thus the number of partitions per rank for a partitioned dataset are always
	/// different.
	/// </remarks>
	// Token: 0x02000834 RID: 2100
	public class vtkPartitionedDataSetCollectionSource : vtkPartitionedDataSetCollectionAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06015BA2 RID: 88994 RVA: 0x001EA933 File Offset: 0x001E8B33
		static vtkPartitionedDataSetCollectionSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPartitionedDataSetCollectionSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPartitionedDataSetCollectionSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06015BA3 RID: 88995 RVA: 0x001EA95B File Offset: 0x001E8B5B
		public vtkPartitionedDataSetCollectionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06015BA4 RID: 88996
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BA5 RID: 88997 RVA: 0x001EA96C File Offset: 0x001E8B6C
		public new static vtkPartitionedDataSetCollectionSource New()
		{
			vtkPartitionedDataSetCollectionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BA6 RID: 88998 RVA: 0x001EA9C0 File Offset: 0x001E8BC0
		public vtkPartitionedDataSetCollectionSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06015BA7 RID: 88999 RVA: 0x001EAA04 File Offset: 0x001E8C04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06015BA8 RID: 89000
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BA9 RID: 89001 RVA: 0x001EAA10 File Offset: 0x001E8C10
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06015BAA RID: 89002
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BAB RID: 89003 RVA: 0x001EAA30 File Offset: 0x001E8C30
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06015BAC RID: 89004
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapes_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of partitioned datasets in the collection.
		/// </summary>
		// Token: 0x06015BAD RID: 89005 RVA: 0x001EAA4C File Offset: 0x001E8C4C
		public virtual int GetNumberOfShapes()
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_GetNumberOfShapes_03(base.GetCppThis());
		}

		// Token: 0x06015BAE RID: 89006
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of partitioned datasets in the collection.
		/// </summary>
		// Token: 0x06015BAF RID: 89007 RVA: 0x001EAA6C File Offset: 0x001E8C6C
		public virtual int GetNumberOfShapesMaxValue()
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06015BB0 RID: 89008
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMinValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the number of partitioned datasets in the collection.
		/// </summary>
		// Token: 0x06015BB1 RID: 89009 RVA: 0x001EAA8C File Offset: 0x001E8C8C
		public virtual int GetNumberOfShapesMinValue()
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_GetNumberOfShapesMinValue_05(base.GetCppThis());
		}

		// Token: 0x06015BB2 RID: 89010
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionSource_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BB3 RID: 89011 RVA: 0x001EAAAC File Offset: 0x001E8CAC
		public override int IsA(string type)
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06015BB4 RID: 89012
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPartitionedDataSetCollectionSource_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BB5 RID: 89013 RVA: 0x001EAACC File Offset: 0x001E8CCC
		public new static int IsTypeOf(string type)
		{
			return vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_IsTypeOf_07(type);
		}

		// Token: 0x06015BB6 RID: 89014
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionSource_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BB7 RID: 89015 RVA: 0x001EAAE8 File Offset: 0x001E8CE8
		public new vtkPartitionedDataSetCollectionSource NewInstance()
		{
			vtkPartitionedDataSetCollectionSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06015BB8 RID: 89016
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPartitionedDataSetCollectionSource_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06015BB9 RID: 89017 RVA: 0x001EAB44 File Offset: 0x001E8D44
		public new static vtkPartitionedDataSetCollectionSource SafeDownCast(vtkObjectBase o)
		{
			vtkPartitionedDataSetCollectionSource vtkPartitionedDataSetCollectionSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPartitionedDataSetCollectionSource = (vtkPartitionedDataSetCollectionSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPartitionedDataSetCollectionSource.Register(null);
				}
			}
			return vtkPartitionedDataSetCollectionSource;
		}

		// Token: 0x06015BBA RID: 89018
		[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPartitionedDataSetCollectionSource_SetNumberOfShapes_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the number of partitioned datasets in the collection.
		/// </summary>
		// Token: 0x06015BBB RID: 89019 RVA: 0x001EABC3 File Offset: 0x001E8DC3
		public virtual void SetNumberOfShapes(int _arg)
		{
			vtkPartitionedDataSetCollectionSource.vtkPartitionedDataSetCollectionSource_SetNumberOfShapes_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018BF RID: 6335
		public new const string MRFullTypeName = "Kitware.VTK.vtkPartitionedDataSetCollectionSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018C0 RID: 6336
		public new static readonly string MRClassNameKey = "class vtkPartitionedDataSetCollectionSource";
	}
}
