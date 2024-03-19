using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericCellIterator
	/// </summary>
	/// <remarks>
	///    iterator used to traverse cells
	///
	/// This class (and subclasses) are used to iterate over cells. Use it
	/// only in conjunction with vtkGenericDataSet (i.e., the adaptor framework).
	///
	/// Typical use is:
	/// &lt;pre&gt;
	/// vtkGenericDataSet *dataset;
	/// vtkGenericCellIterator *it = dataset-&gt;NewCellIterator(2);
	/// for (it-&gt;Begin(); !it-&gt;IsAtEnd(); it-&gt;Next());
	///   {
	///   spec=it-&gt;GetCell();
	///   }
	/// &lt;/pre&gt;
	/// </remarks>
	// Token: 0x02000A4D RID: 2637
	public abstract class vtkGenericCellIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B8B0 RID: 112816 RVA: 0x00268911 File Offset: 0x00266B11
		static vtkGenericCellIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericCellIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericCellIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8B1 RID: 112817 RVA: 0x00268939 File Offset: 0x00266B39
		public vtkGenericCellIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B8B2 RID: 112818 RVA: 0x00268947 File Offset: 0x00266B47
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B8B3 RID: 112819
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellIterator_Begin_01(HandleRef pThis);

		/// <summary>
		/// Move iterator to first position if any (loop initialization).
		/// </summary>
		// Token: 0x0601B8B4 RID: 112820 RVA: 0x00268952 File Offset: 0x00266B52
		public virtual void Begin()
		{
			vtkGenericCellIterator.vtkGenericCellIterator_Begin_01(base.GetCppThis());
		}

		// Token: 0x0601B8B5 RID: 112821
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellIterator_GetCell_02(HandleRef pThis, HandleRef c);

		/// <summary>
		/// Get the cell at current position. The cell should be instantiated
		/// with the NewCell() method.
		/// \pre not_at_end: !IsAtEnd()
		/// \pre c_exists: c!=0
		/// THREAD SAFE
		/// </summary>
		// Token: 0x0601B8B6 RID: 112822 RVA: 0x00268964 File Offset: 0x00266B64
		public virtual void GetCell(vtkGenericAdaptorCell c)
		{
			vtkGenericCellIterator.vtkGenericCellIterator_GetCell_02(base.GetCppThis(), (c == null) ? default(HandleRef) : c.GetCppThis());
		}

		// Token: 0x0601B8B7 RID: 112823
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellIterator_GetCell_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the cell at the current traversal position.
		/// NOT THREAD SAFE
		/// \pre not_at_end: !IsAtEnd()
		/// \post result_exits: result!=0
		/// </summary>
		// Token: 0x0601B8B8 RID: 112824 RVA: 0x00268994 File Offset: 0x00266B94
		public virtual vtkGenericAdaptorCell GetCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_GetCell_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		// Token: 0x0601B8B9 RID: 112825
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCellIterator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8BA RID: 112826 RVA: 0x00268A04 File Offset: 0x00266C04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B8BB RID: 112827
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericCellIterator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8BC RID: 112828 RVA: 0x00268A24 File Offset: 0x00266C24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B8BD RID: 112829
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellIterator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8BE RID: 112830 RVA: 0x00268A40 File Offset: 0x00266C40
		public override int IsA(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B8BF RID: 112831
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellIterator_IsAtEnd_07(HandleRef pThis);

		/// <summary>
		/// Is the iterator at the end of traversal?
		/// </summary>
		// Token: 0x0601B8C0 RID: 112832 RVA: 0x00268A60 File Offset: 0x00266C60
		public virtual int IsAtEnd()
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsAtEnd_07(base.GetCppThis());
		}

		// Token: 0x0601B8C1 RID: 112833
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericCellIterator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8C2 RID: 112834 RVA: 0x00268A80 File Offset: 0x00266C80
		public new static int IsTypeOf(string type)
		{
			return vtkGenericCellIterator.vtkGenericCellIterator_IsTypeOf_08(type);
		}

		// Token: 0x0601B8C3 RID: 112835
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellIterator_NewCell_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an empty cell. The user is responsible for deleting it.
		/// \post result_exists: result!=0
		/// </summary>
		// Token: 0x0601B8C4 RID: 112836 RVA: 0x00268A9C File Offset: 0x00266C9C
		public virtual vtkGenericAdaptorCell NewCell()
		{
			vtkGenericAdaptorCell vtkGenericAdaptorCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_NewCell_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericAdaptorCell = (vtkGenericAdaptorCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericAdaptorCell.Register(null);
				}
			}
			return vtkGenericAdaptorCell;
		}

		// Token: 0x0601B8C5 RID: 112837
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8C6 RID: 112838 RVA: 0x00268B0C File Offset: 0x00266D0C
		public new vtkGenericCellIterator NewInstance()
		{
			vtkGenericCellIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B8C7 RID: 112839
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenericCellIterator_Next_11(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the next position in the list.
		/// \pre not_at_end: !IsAtEnd()
		/// </summary>
		// Token: 0x0601B8C8 RID: 112840 RVA: 0x00268B66 File Offset: 0x00266D66
		public virtual void Next()
		{
			vtkGenericCellIterator.vtkGenericCellIterator_Next_11(base.GetCppThis());
		}

		// Token: 0x0601B8C9 RID: 112841
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericCellIterator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK construction and type macros.
		/// </summary>
		// Token: 0x0601B8CA RID: 112842 RVA: 0x00268B78 File Offset: 0x00266D78
		public new static vtkGenericCellIterator SafeDownCast(vtkObjectBase o)
		{
			vtkGenericCellIterator vtkGenericCellIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericCellIterator.vtkGenericCellIterator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericCellIterator = (vtkGenericCellIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericCellIterator.Register(null);
				}
			}
			return vtkGenericCellIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8E RID: 7566
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericCellIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D8F RID: 7567
		public new static readonly string MRClassNameKey = "class vtkGenericCellIterator";
	}
}
