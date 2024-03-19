using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSpherePuzzleArrows
	/// </summary>
	/// <remarks>
	///    Visualize permutation of the sphere puzzle.
	///
	/// vtkSpherePuzzleArrows creates
	/// </remarks>
	// Token: 0x02000571 RID: 1393
	public class vtkSpherePuzzleArrows : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F71C RID: 63260 RVA: 0x001577A6 File Offset: 0x001559A6
		static vtkSpherePuzzleArrows()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSpherePuzzleArrows.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSpherePuzzleArrows"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F71D RID: 63261 RVA: 0x001577CE File Offset: 0x001559CE
		public vtkSpherePuzzleArrows(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F71E RID: 63262
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzleArrows_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F71F RID: 63263 RVA: 0x001577DC File Offset: 0x001559DC
		public new static vtkSpherePuzzleArrows New()
		{
			vtkSpherePuzzleArrows result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F720 RID: 63264 RVA: 0x00157830 File Offset: 0x00155A30
		public vtkSpherePuzzleArrows() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F721 RID: 63265 RVA: 0x00157874 File Offset: 0x00155A74
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F722 RID: 63266
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F723 RID: 63267 RVA: 0x00157880 File Offset: 0x00155A80
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F724 RID: 63268
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F725 RID: 63269 RVA: 0x001578A0 File Offset: 0x00155AA0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F726 RID: 63270
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzleArrows_GetPermutation_03(HandleRef pThis);

		/// <summary>
		/// Permutation is an array of puzzle piece ids.
		/// Arrows will be generated for any id that does not contain itself.
		/// Permutation[3] = 3 will produce no arrow.
		/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
		/// </summary>
		// Token: 0x0600F727 RID: 63271 RVA: 0x001578BC File Offset: 0x00155ABC
		public virtual int[] GetPermutation()
		{
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetPermutation_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F728 RID: 63272
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzleArrows_GetPermutation_04(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Permutation is an array of puzzle piece ids.
		/// Arrows will be generated for any id that does not contain itself.
		/// Permutation[3] = 3 will produce no arrow.
		/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
		/// </summary>
		// Token: 0x0600F729 RID: 63273 RVA: 0x00157904 File Offset: 0x00155B04
		public virtual void GetPermutation(IntPtr data)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_GetPermutation_04(base.GetCppThis(), data);
		}

		// Token: 0x0600F72A RID: 63274
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpherePuzzleArrows_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F72B RID: 63275 RVA: 0x00157914 File Offset: 0x00155B14
		public override int IsA(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600F72C RID: 63276
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSpherePuzzleArrows_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F72D RID: 63277 RVA: 0x00157934 File Offset: 0x00155B34
		public new static int IsTypeOf(string type)
		{
			return vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_IsTypeOf_06(type);
		}

		// Token: 0x0600F72E RID: 63278
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzleArrows_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F72F RID: 63279 RVA: 0x00157950 File Offset: 0x00155B50
		public new vtkSpherePuzzleArrows NewInstance()
		{
			vtkSpherePuzzleArrows result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F730 RID: 63280
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSpherePuzzleArrows_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F731 RID: 63281 RVA: 0x001579AC File Offset: 0x00155BAC
		public new static vtkSpherePuzzleArrows SafeDownCast(vtkObjectBase o)
		{
			vtkSpherePuzzleArrows vtkSpherePuzzleArrows = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSpherePuzzleArrows = (vtkSpherePuzzleArrows)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSpherePuzzleArrows.Register(null);
				}
			}
			return vtkSpherePuzzleArrows;
		}

		// Token: 0x0600F732 RID: 63282
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzleArrows_SetPermutation_10(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Permutation is an array of puzzle piece ids.
		/// Arrows will be generated for any id that does not contain itself.
		/// Permutation[3] = 3 will produce no arrow.
		/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
		/// </summary>
		// Token: 0x0600F733 RID: 63283 RVA: 0x00157A2B File Offset: 0x00155C2B
		public virtual void SetPermutation(IntPtr data)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutation_10(base.GetCppThis(), data);
		}

		// Token: 0x0600F734 RID: 63284
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzleArrows_SetPermutation_11(HandleRef pThis, HandleRef puz);

		/// <summary>
		/// Permutation is an array of puzzle piece ids.
		/// Arrows will be generated for any id that does not contain itself.
		/// Permutation[3] = 3 will produce no arrow.
		/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
		/// </summary>
		// Token: 0x0600F735 RID: 63285 RVA: 0x00157A3C File Offset: 0x00155C3C
		public void SetPermutation(vtkSpherePuzzle puz)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutation_11(base.GetCppThis(), (puz == null) ? default(HandleRef) : puz.GetCppThis());
		}

		// Token: 0x0600F736 RID: 63286
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSpherePuzzleArrows_SetPermutationComponent_12(HandleRef pThis, int comp, int val);

		/// <summary>
		/// Permutation is an array of puzzle piece ids.
		/// Arrows will be generated for any id that does not contain itself.
		/// Permutation[3] = 3 will produce no arrow.
		/// Permutation[3] = 10 will draw an arrow from location 3 to 10.
		/// </summary>
		// Token: 0x0600F737 RID: 63287 RVA: 0x00157A6B File Offset: 0x00155C6B
		public void SetPermutationComponent(int comp, int val)
		{
			vtkSpherePuzzleArrows.vtkSpherePuzzleArrows_SetPermutationComponent_12(base.GetCppThis(), comp, val);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F3 RID: 4595
		public new const string MRFullTypeName = "Kitware.VTK.vtkSpherePuzzleArrows";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F4 RID: 4596
		public new static readonly string MRClassNameKey = "class vtkSpherePuzzleArrows";
	}
}
