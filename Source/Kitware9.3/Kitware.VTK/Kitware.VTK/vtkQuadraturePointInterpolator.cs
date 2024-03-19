using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkQuadraturePointInterpolator
	///
	///
	/// Interpolates each scalar/vector field in a vtkUnstrcturedGrid
	/// on its input to a specific set of quadrature points. The
	/// set of quadrature points is specified per array via a
	/// dictionary (ie an instance of vtkInformationQuadratureSchemeDefinitionVectorKey).
	/// contained in the array. The interpolated fields are placed
	/// in FieldData along with a set of per cell indexes, that allow
	/// random access to a given cells quadrature points.
	///
	/// </summary>
	/// <seealso>
	///
	/// vtkQuadratureSchemeDefinition, vtkQuadraturePointsGenerator,
	/// vtkInformationQuadratureSchemeDefinitionVectorKey
	/// </seealso>
	// Token: 0x020008CE RID: 2254
	public class vtkQuadraturePointInterpolator : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017483 RID: 95363 RVA: 0x0020B257 File Offset: 0x00209457
		static vtkQuadraturePointInterpolator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkQuadraturePointInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkQuadraturePointInterpolator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017484 RID: 95364 RVA: 0x0020B27F File Offset: 0x0020947F
		public vtkQuadraturePointInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017485 RID: 95365
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraturePointInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017486 RID: 95366 RVA: 0x0020B290 File Offset: 0x00209490
		public new static vtkQuadraturePointInterpolator New()
		{
			vtkQuadraturePointInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017487 RID: 95367 RVA: 0x0020B2E4 File Offset: 0x002094E4
		public vtkQuadraturePointInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017488 RID: 95368 RVA: 0x0020B328 File Offset: 0x00209528
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017489 RID: 95369
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraturePointInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601748A RID: 95370 RVA: 0x0020B334 File Offset: 0x00209534
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601748B RID: 95371
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkQuadraturePointInterpolator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601748C RID: 95372 RVA: 0x0020B354 File Offset: 0x00209554
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601748D RID: 95373
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraturePointInterpolator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601748E RID: 95374 RVA: 0x0020B370 File Offset: 0x00209570
		public override int IsA(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601748F RID: 95375
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkQuadraturePointInterpolator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017490 RID: 95376 RVA: 0x0020B390 File Offset: 0x00209590
		public new static int IsTypeOf(string type)
		{
			return vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_IsTypeOf_04(type);
		}

		// Token: 0x06017491 RID: 95377
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraturePointInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017492 RID: 95378 RVA: 0x0020B3AC File Offset: 0x002095AC
		public new vtkQuadraturePointInterpolator NewInstance()
		{
			vtkQuadraturePointInterpolator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017493 RID: 95379
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkQuadraturePointInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017494 RID: 95380 RVA: 0x0020B408 File Offset: 0x00209608
		public new static vtkQuadraturePointInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkQuadraturePointInterpolator vtkQuadraturePointInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkQuadraturePointInterpolator.vtkQuadraturePointInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkQuadraturePointInterpolator = (vtkQuadraturePointInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkQuadraturePointInterpolator.Register(null);
				}
			}
			return vtkQuadraturePointInterpolator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A0F RID: 6671
		public new const string MRFullTypeName = "Kitware.VTK.vtkQuadraturePointInterpolator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A10 RID: 6672
		public new static readonly string MRClassNameKey = "class vtkQuadraturePointInterpolator";
	}
}
