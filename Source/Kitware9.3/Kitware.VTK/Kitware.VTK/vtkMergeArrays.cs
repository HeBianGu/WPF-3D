using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMergeArrays
	/// </summary>
	/// <remarks>
	///    Multiple inputs with one output.
	///
	/// vtkMergeArrays tries to put all arrays from all inputs into one output.
	/// The output data object is the same as the first data input.
	/// The filter checks for a consistent number of points and cells with
	/// respect to the first input, but does not check any more. Any inputs
	/// which do not have the correct number of points or cells are ignored
	/// for that type of data set attribute. When adding new arrays, if there
	/// is an existing array of the same name and attribute type, the new array
	/// will have the name mangled to be the original array name plus
	/// `_input_&lt;inputid&gt;` where `&lt;inputid&gt;` is the id/index of the input filter
	/// that is providing that array.
	/// </remarks>
	// Token: 0x0200051F RID: 1311
	public class vtkMergeArrays : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EAD6 RID: 60118 RVA: 0x001476DB File Offset: 0x001458DB
		static vtkMergeArrays()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeArrays.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeArrays"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAD7 RID: 60119 RVA: 0x00147703 File Offset: 0x00145903
		public vtkMergeArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EAD8 RID: 60120
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAD9 RID: 60121 RVA: 0x00147714 File Offset: 0x00145914
		public new static vtkMergeArrays New()
		{
			vtkMergeArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeArrays.vtkMergeArrays_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EADA RID: 60122 RVA: 0x00147768 File Offset: 0x00145968
		public vtkMergeArrays() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMergeArrays.vtkMergeArrays_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EADB RID: 60123 RVA: 0x001477AC File Offset: 0x001459AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EADC RID: 60124
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeArrays_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EADD RID: 60125 RVA: 0x001477B8 File Offset: 0x001459B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMergeArrays.vtkMergeArrays_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EADE RID: 60126
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMergeArrays_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EADF RID: 60127 RVA: 0x001477D8 File Offset: 0x001459D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMergeArrays.vtkMergeArrays_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EAE0 RID: 60128
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeArrays_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAE1 RID: 60129 RVA: 0x001477F4 File Offset: 0x001459F4
		public override int IsA(string type)
		{
			return vtkMergeArrays.vtkMergeArrays_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EAE2 RID: 60130
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMergeArrays_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAE3 RID: 60131 RVA: 0x00147814 File Offset: 0x00145A14
		public new static int IsTypeOf(string type)
		{
			return vtkMergeArrays.vtkMergeArrays_IsTypeOf_04(type);
		}

		// Token: 0x0600EAE4 RID: 60132
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeArrays_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAE5 RID: 60133 RVA: 0x00147830 File Offset: 0x00145A30
		public new vtkMergeArrays NewInstance()
		{
			vtkMergeArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeArrays.vtkMergeArrays_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EAE6 RID: 60134
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMergeArrays_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAE7 RID: 60135 RVA: 0x0014788C File Offset: 0x00145A8C
		public new static vtkMergeArrays SafeDownCast(vtkObjectBase o)
		{
			vtkMergeArrays vtkMergeArrays = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMergeArrays.vtkMergeArrays_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeArrays = (vtkMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeArrays.Register(null);
				}
			}
			return vtkMergeArrays;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400112D RID: 4397
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeArrays";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400112E RID: 4398
		public new static readonly string MRClassNameKey = "class vtkMergeArrays";
	}
}
