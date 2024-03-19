using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringToCategory
	/// </summary>
	/// <remarks>
	///    Creates a category array from a string array
	///
	///
	/// vtkStringToCategory creates an integer array named "category" based on the
	/// values in a string array.  You may use this filter to create an array that
	/// you may use to color points/cells by the values in a string array.  Currently
	/// there is not support to color by a string array directly.
	/// The category values will range from zero to N-1,
	/// where N is the number of distinct strings in the string array.  Set the string
	/// array to process with SetInputArrayToProcess(0,0,0,...).  The array may be in
	/// the point, cell, or field data of the data object.
	///
	/// The list of unique strings, in the order they are mapped, can also be
	/// retrieved from output port 1. They are in a vtkTable, stored in the "Strings"
	/// column as a vtkStringArray.
	/// </remarks>
	// Token: 0x02000692 RID: 1682
	public class vtkStringToCategory : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012075 RID: 73845 RVA: 0x00193E51 File Offset: 0x00192051
		static vtkStringToCategory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToCategory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToCategory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012076 RID: 73846 RVA: 0x00193E79 File Offset: 0x00192079
		public vtkStringToCategory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012077 RID: 73847
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToCategory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012078 RID: 73848 RVA: 0x00193E88 File Offset: 0x00192088
		public new static vtkStringToCategory New()
		{
			vtkStringToCategory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012079 RID: 73849 RVA: 0x00193EDC File Offset: 0x001920DC
		public vtkStringToCategory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStringToCategory.vtkStringToCategory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601207A RID: 73850 RVA: 0x00193F20 File Offset: 0x00192120
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601207B RID: 73851
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToCategory_GetCategoryArrayName_01(HandleRef pThis);

		/// <summary>
		/// The name to give to the output vtkIntArray of category values.
		/// </summary>
		// Token: 0x0601207C RID: 73852 RVA: 0x00193F2C File Offset: 0x0019212C
		public virtual string GetCategoryArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkStringToCategory.vtkStringToCategory_GetCategoryArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601207D RID: 73853
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToCategory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601207E RID: 73854 RVA: 0x00193F68 File Offset: 0x00192168
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601207F RID: 73855
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStringToCategory_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012080 RID: 73856 RVA: 0x00193F88 File Offset: 0x00192188
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012081 RID: 73857
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToCategory_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012082 RID: 73858 RVA: 0x00193FA4 File Offset: 0x001921A4
		public override int IsA(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012083 RID: 73859
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStringToCategory_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012084 RID: 73860 RVA: 0x00193FC4 File Offset: 0x001921C4
		public new static int IsTypeOf(string type)
		{
			return vtkStringToCategory.vtkStringToCategory_IsTypeOf_05(type);
		}

		// Token: 0x06012085 RID: 73861
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToCategory_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012086 RID: 73862 RVA: 0x00193FE0 File Offset: 0x001921E0
		public new vtkStringToCategory NewInstance()
		{
			vtkStringToCategory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012087 RID: 73863
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStringToCategory_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012088 RID: 73864 RVA: 0x0019403C File Offset: 0x0019223C
		public new static vtkStringToCategory SafeDownCast(vtkObjectBase o)
		{
			vtkStringToCategory vtkStringToCategory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStringToCategory.vtkStringToCategory_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToCategory = (vtkStringToCategory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToCategory.Register(null);
				}
			}
			return vtkStringToCategory;
		}

		// Token: 0x06012089 RID: 73865
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStringToCategory_SetCategoryArrayName_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name to give to the output vtkIntArray of category values.
		/// </summary>
		// Token: 0x0601208A RID: 73866 RVA: 0x001940BB File Offset: 0x001922BB
		public virtual void SetCategoryArrayName(string _arg)
		{
			vtkStringToCategory.vtkStringToCategory_SetCategoryArrayName_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CF RID: 5327
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToCategory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014D0 RID: 5328
		public new static readonly string MRClassNameKey = "class vtkStringToCategory";
	}
}
