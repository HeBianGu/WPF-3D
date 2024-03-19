using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractSelectedLocations
	/// </summary>
	/// <remarks>
	///    extract cells within a dataset that
	/// contain the locations listen in the vtkSelection.
	///
	/// vtkExtractSelectedLocations extracts all cells whose volume contain at least
	/// one point listed in the LOCATIONS content of the vtkSelection. This filter
	/// adds a scalar array called vtkOriginalCellIds that says what input cell
	/// produced each output cell. This is an example of a Pedigree ID which helps
	/// to trace back results.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSelection vtkExtractSelection
	///
	/// @deprecated vtkExtractSelectedLocations is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkExtractSelection` instead of `vtkExtractSelectedLocations`.
	///
	/// Example using vtkExtractSelectedLocations:
	///
	/// vtkNew&lt;vtkExtractSelectedLocations&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	///
	/// Example using vtkExtractSelection:
	///
	/// vtkNew&lt;vtkExtractSelection&gt; selFilter;
	/// selFilter-&gt;SetInputConnection(0, sphereSource-&gt;GetOutputPort());
	/// selFilter-&gt;SetInputConnection(1, selectionSource-&gt;GetOutputPort());
	/// </seealso>
	// Token: 0x020006B4 RID: 1716
	public class vtkExtractSelectedLocations : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601251D RID: 75037 RVA: 0x0019ABB7 File Offset: 0x00198DB7
		static vtkExtractSelectedLocations()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractSelectedLocations.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractSelectedLocations"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601251E RID: 75038 RVA: 0x0019ABDF File Offset: 0x00198DDF
		public vtkExtractSelectedLocations(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601251F RID: 75039
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedLocations_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012520 RID: 75040 RVA: 0x0019ABF0 File Offset: 0x00198DF0
		public new static vtkExtractSelectedLocations New()
		{
			vtkExtractSelectedLocations result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012521 RID: 75041 RVA: 0x0019AC44 File Offset: 0x00198E44
		public vtkExtractSelectedLocations() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractSelectedLocations.vtkExtractSelectedLocations_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012522 RID: 75042 RVA: 0x0019AC88 File Offset: 0x00198E88
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012523 RID: 75043
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedLocations_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012524 RID: 75044 RVA: 0x0019AC94 File Offset: 0x00198E94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012525 RID: 75045
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractSelectedLocations_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012526 RID: 75046 RVA: 0x0019ACB4 File Offset: 0x00198EB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012527 RID: 75047
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedLocations_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012528 RID: 75048 RVA: 0x0019ACD0 File Offset: 0x00198ED0
		public override int IsA(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012529 RID: 75049
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractSelectedLocations_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601252A RID: 75050 RVA: 0x0019ACF0 File Offset: 0x00198EF0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractSelectedLocations.vtkExtractSelectedLocations_IsTypeOf_04(type);
		}

		// Token: 0x0601252B RID: 75051
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedLocations_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601252C RID: 75052 RVA: 0x0019AD0C File Offset: 0x00198F0C
		public new vtkExtractSelectedLocations NewInstance()
		{
			vtkExtractSelectedLocations result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601252D RID: 75053
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractSelectedLocations_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601252E RID: 75054 RVA: 0x0019AD68 File Offset: 0x00198F68
		public new static vtkExtractSelectedLocations SafeDownCast(vtkObjectBase o)
		{
			vtkExtractSelectedLocations vtkExtractSelectedLocations = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractSelectedLocations.vtkExtractSelectedLocations_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractSelectedLocations = (vtkExtractSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractSelectedLocations.Register(null);
				}
			}
			return vtkExtractSelectedLocations;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001516 RID: 5398
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractSelectedLocations";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001517 RID: 5399
		public new static readonly string MRClassNameKey = "class vtkExtractSelectedLocations";
	}
}
