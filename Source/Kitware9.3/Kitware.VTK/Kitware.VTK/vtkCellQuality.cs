using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellQuality
	/// </summary>
	/// <remarks>
	///    Calculate functions of quality of the elements of a mesh
	///
	/// vtkCellQuality computes one or more functions of (geometric) quality for each
	/// cell of a mesh.  The per-cell quality is added to the mesh's cell data, in an
	/// array named "CellQuality." Cell types not supported by this filter or undefined
	/// quality of supported cell types will have an entry of -1.
	///
	/// @warning
	/// Most quadrilateral quality functions are intended for planar quadrilaterals
	/// only.  The minimal angle is not, strictly speaking, a quality function, but
	/// it is provided because of its usage by many authors.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x020008FE RID: 2302
	public class vtkCellQuality : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017C61 RID: 97377 RVA: 0x002154C7 File Offset: 0x002136C7
		static vtkCellQuality()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellQuality.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellQuality"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017C62 RID: 97378 RVA: 0x002154EF File Offset: 0x002136EF
		public vtkCellQuality(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017C63 RID: 97379
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellQuality_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C64 RID: 97380 RVA: 0x00215500 File Offset: 0x00213700
		public new static vtkCellQuality New()
		{
			vtkCellQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C65 RID: 97381 RVA: 0x00215554 File Offset: 0x00213754
		public vtkCellQuality() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellQuality.vtkCellQuality_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017C66 RID: 97382 RVA: 0x00215598 File Offset: 0x00213798
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017C67 RID: 97383
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellQuality_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C68 RID: 97384 RVA: 0x002155A4 File Offset: 0x002137A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellQuality.vtkCellQuality_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017C69 RID: 97385
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellQuality_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C6A RID: 97386 RVA: 0x002155C4 File Offset: 0x002137C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellQuality.vtkCellQuality_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017C6B RID: 97387
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkMeshQuality.QualityMeasureTypes vtkCellQuality_GetQualityMeasure_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C6C RID: 97388 RVA: 0x002155E0 File Offset: 0x002137E0
		public virtual vtkMeshQuality.QualityMeasureTypes GetQualityMeasure()
		{
			return vtkCellQuality.vtkCellQuality_GetQualityMeasure_03(base.GetCppThis());
		}

		// Token: 0x06017C6D RID: 97389
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellQuality_GetUndefinedQuality_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the return value for undefined quality. Undefined quality
		/// are qualities that could be addressed by this filter but is not well
		/// defined for the particular geometry of cell in question, e.g. a
		/// volume query for a triangle. Undefined quality will always be undefined.
		/// The default value for UndefinedQuality is -1.
		/// </summary>
		// Token: 0x06017C6E RID: 97390 RVA: 0x00215600 File Offset: 0x00213800
		public virtual double GetUndefinedQuality()
		{
			return vtkCellQuality.vtkCellQuality_GetUndefinedQuality_04(base.GetCppThis());
		}

		// Token: 0x06017C6F RID: 97391
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellQuality_GetUnsupportedGeometry_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the return value for unsupported geometry. Unsupported geometry
		/// are geometries that are not supported by this filter currently, future
		/// implementation might include support for them. The default value for
		/// UnsupportedGeometry is -1.
		/// </summary>
		// Token: 0x06017C70 RID: 97392 RVA: 0x00215620 File Offset: 0x00213820
		public virtual double GetUnsupportedGeometry()
		{
			return vtkCellQuality.vtkCellQuality_GetUnsupportedGeometry_05(base.GetCppThis());
		}

		// Token: 0x06017C71 RID: 97393
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellQuality_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C72 RID: 97394 RVA: 0x00215640 File Offset: 0x00213840
		public override int IsA(string type)
		{
			return vtkCellQuality.vtkCellQuality_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017C73 RID: 97395
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellQuality_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C74 RID: 97396 RVA: 0x00215660 File Offset: 0x00213860
		public new static int IsTypeOf(string type)
		{
			return vtkCellQuality.vtkCellQuality_IsTypeOf_07(type);
		}

		// Token: 0x06017C75 RID: 97397
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellQuality_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C76 RID: 97398 RVA: 0x0021567C File Offset: 0x0021387C
		public new vtkCellQuality NewInstance()
		{
			vtkCellQuality result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017C77 RID: 97399
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellQuality_PixelArea_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the return value for undefined quality. Undefined quality
		/// are qualities that could be addressed by this filter but is not well
		/// defined for the particular geometry of cell in question, e.g. a
		/// volume query for a triangle. Undefined quality will always be undefined.
		/// The default value for UndefinedQuality is -1.
		/// </summary>
		// Token: 0x06017C78 RID: 97400 RVA: 0x002156D8 File Offset: 0x002138D8
		public double PixelArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_PixelArea_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017C79 RID: 97401
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellQuality_PolygonArea_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the return value for undefined quality. Undefined quality
		/// are qualities that could be addressed by this filter but is not well
		/// defined for the particular geometry of cell in question, e.g. a
		/// volume query for a triangle. Undefined quality will always be undefined.
		/// The default value for UndefinedQuality is -1.
		/// </summary>
		// Token: 0x06017C7A RID: 97402 RVA: 0x0021570C File Offset: 0x0021390C
		public double PolygonArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_PolygonArea_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06017C7B RID: 97403
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellQuality_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017C7C RID: 97404 RVA: 0x00215740 File Offset: 0x00213940
		public new static vtkCellQuality SafeDownCast(vtkObjectBase o)
		{
			vtkCellQuality vtkCellQuality = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellQuality.vtkCellQuality_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellQuality = (vtkCellQuality)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellQuality.Register(null);
				}
			}
			return vtkCellQuality;
		}

		// Token: 0x06017C7D RID: 97405
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasure_13(HandleRef pThis, vtkMeshQuality.QualityMeasureTypes _arg);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C7E RID: 97406 RVA: 0x002157BF File Offset: 0x002139BF
		public virtual void SetQualityMeasure(vtkMeshQuality.QualityMeasureTypes _arg)
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasure_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06017C7F RID: 97407
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasure_14(HandleRef pThis, int measure);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C80 RID: 97408 RVA: 0x002157CF File Offset: 0x002139CF
		public virtual void SetQualityMeasure(int measure)
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasure_14(base.GetCppThis(), measure);
		}

		// Token: 0x06017C81 RID: 97409
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToArea_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C82 RID: 97410 RVA: 0x002157DF File Offset: 0x002139DF
		public void SetQualityMeasureToArea()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToArea_15(base.GetCppThis());
		}

		// Token: 0x06017C83 RID: 97411
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectFrobenius_16(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C84 RID: 97412 RVA: 0x002157EE File Offset: 0x002139EE
		public void SetQualityMeasureToAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectFrobenius_16(base.GetCppThis());
		}

		// Token: 0x06017C85 RID: 97413
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectGamma_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C86 RID: 97414 RVA: 0x002157FD File Offset: 0x002139FD
		public void SetQualityMeasureToAspectGamma()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectGamma_17(base.GetCppThis());
		}

		// Token: 0x06017C87 RID: 97415
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToAspectRatio_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C88 RID: 97416 RVA: 0x0021580C File Offset: 0x00213A0C
		public void SetQualityMeasureToAspectRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToAspectRatio_18(base.GetCppThis());
		}

		// Token: 0x06017C89 RID: 97417
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToCollapseRatio_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C8A RID: 97418 RVA: 0x0021581B File Offset: 0x00213A1B
		public void SetQualityMeasureToCollapseRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToCollapseRatio_19(base.GetCppThis());
		}

		// Token: 0x06017C8B RID: 97419
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToCondition_20(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C8C RID: 97420 RVA: 0x0021582A File Offset: 0x00213A2A
		public void SetQualityMeasureToCondition()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToCondition_20(base.GetCppThis());
		}

		// Token: 0x06017C8D RID: 97421
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToDiagonal_21(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C8E RID: 97422 RVA: 0x00215839 File Offset: 0x00213A39
		public void SetQualityMeasureToDiagonal()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDiagonal_21(base.GetCppThis());
		}

		// Token: 0x06017C8F RID: 97423
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToDimension_22(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C90 RID: 97424 RVA: 0x00215848 File Offset: 0x00213A48
		public void SetQualityMeasureToDimension()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDimension_22(base.GetCppThis());
		}

		// Token: 0x06017C91 RID: 97425
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToDistortion_23(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C92 RID: 97426 RVA: 0x00215857 File Offset: 0x00213A57
		public void SetQualityMeasureToDistortion()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToDistortion_23(base.GetCppThis());
		}

		// Token: 0x06017C93 RID: 97427
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToJacobian_24(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C94 RID: 97428 RVA: 0x00215866 File Offset: 0x00213A66
		public void SetQualityMeasureToJacobian()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToJacobian_24(base.GetCppThis());
		}

		// Token: 0x06017C95 RID: 97429
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxAngle_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C96 RID: 97430 RVA: 0x00215875 File Offset: 0x00213A75
		public void SetQualityMeasureToMaxAngle()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxAngle_25(base.GetCppThis());
		}

		// Token: 0x06017C97 RID: 97431
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_26(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C98 RID: 97432 RVA: 0x00215884 File Offset: 0x00213A84
		public void SetQualityMeasureToMaxAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxAspectFrobenius_26(base.GetCppThis());
		}

		// Token: 0x06017C99 RID: 97433
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_27(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C9A RID: 97434 RVA: 0x00215893 File Offset: 0x00213A93
		public void SetQualityMeasureToMaxEdgeRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMaxEdgeRatio_27(base.GetCppThis());
		}

		// Token: 0x06017C9B RID: 97435
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_28(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C9C RID: 97436 RVA: 0x002158A2 File Offset: 0x00213AA2
		public void SetQualityMeasureToMedAspectFrobenius()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMedAspectFrobenius_28(base.GetCppThis());
		}

		// Token: 0x06017C9D RID: 97437
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToMinAngle_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017C9E RID: 97438 RVA: 0x002158B1 File Offset: 0x00213AB1
		public void SetQualityMeasureToMinAngle()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToMinAngle_29(base.GetCppThis());
		}

		// Token: 0x06017C9F RID: 97439
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToOddy_30(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CA0 RID: 97440 RVA: 0x002158C0 File Offset: 0x00213AC0
		public void SetQualityMeasureToOddy()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToOddy_30(base.GetCppThis());
		}

		// Token: 0x06017CA1 RID: 97441
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToRadiusRatio_31(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CA2 RID: 97442 RVA: 0x002158CF File Offset: 0x00213ACF
		public void SetQualityMeasureToRadiusRatio()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToRadiusRatio_31(base.GetCppThis());
		}

		// Token: 0x06017CA3 RID: 97443
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_32(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CA4 RID: 97444 RVA: 0x002158DE File Offset: 0x00213ADE
		public void SetQualityMeasureToRelativeSizeSquared()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToRelativeSizeSquared_32(base.GetCppThis());
		}

		// Token: 0x06017CA5 RID: 97445
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToScaledJacobian_33(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CA6 RID: 97446 RVA: 0x002158ED File Offset: 0x00213AED
		public void SetQualityMeasureToScaledJacobian()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToScaledJacobian_33(base.GetCppThis());
		}

		// Token: 0x06017CA7 RID: 97447
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToShape_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CA8 RID: 97448 RVA: 0x002158FC File Offset: 0x00213AFC
		public void SetQualityMeasureToShape()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShape_34(base.GetCppThis());
		}

		// Token: 0x06017CA9 RID: 97449
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToShapeAndSize_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CAA RID: 97450 RVA: 0x0021590B File Offset: 0x00213B0B
		public void SetQualityMeasureToShapeAndSize()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShapeAndSize_35(base.GetCppThis());
		}

		// Token: 0x06017CAB RID: 97451
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToShear_36(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CAC RID: 97452 RVA: 0x0021591A File Offset: 0x00213B1A
		public void SetQualityMeasureToShear()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShear_36(base.GetCppThis());
		}

		// Token: 0x06017CAD RID: 97453
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToShearAndSize_37(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CAE RID: 97454 RVA: 0x00215929 File Offset: 0x00213B29
		public void SetQualityMeasureToShearAndSize()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToShearAndSize_37(base.GetCppThis());
		}

		// Token: 0x06017CAF RID: 97455
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToSkew_38(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CB0 RID: 97456 RVA: 0x00215938 File Offset: 0x00213B38
		public void SetQualityMeasureToSkew()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToSkew_38(base.GetCppThis());
		}

		// Token: 0x06017CB1 RID: 97457
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToStretch_39(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CB2 RID: 97458 RVA: 0x00215947 File Offset: 0x00213B47
		public void SetQualityMeasureToStretch()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToStretch_39(base.GetCppThis());
		}

		// Token: 0x06017CB3 RID: 97459
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToTaper_40(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CB4 RID: 97460 RVA: 0x00215956 File Offset: 0x00213B56
		public void SetQualityMeasureToTaper()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToTaper_40(base.GetCppThis());
		}

		// Token: 0x06017CB5 RID: 97461
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToVolume_41(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CB6 RID: 97462 RVA: 0x00215965 File Offset: 0x00213B65
		public void SetQualityMeasureToVolume()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToVolume_41(base.GetCppThis());
		}

		// Token: 0x06017CB7 RID: 97463
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetQualityMeasureToWarpage_42(HandleRef pThis);

		/// <summary>
		/// Set/Get the particular estimator used to function the quality of all
		/// supported geometries. For qualities that are not defined for certain
		/// geometries, later program logic ensures that CellQualityNone static
		/// function will be used so that a predefined value is returned for the
		/// request.
		/// There is no default value for this call and valid values include all
		/// possible qualities supported by this class.
		///
		/// For Quality Measure values see vtkMeshQuality's enum QualityMeasureType.
		/// </summary>
		// Token: 0x06017CB8 RID: 97464 RVA: 0x00215974 File Offset: 0x00213B74
		public void SetQualityMeasureToWarpage()
		{
			vtkCellQuality.vtkCellQuality_SetQualityMeasureToWarpage_42(base.GetCppThis());
		}

		// Token: 0x06017CB9 RID: 97465
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetUndefinedQuality_43(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the return value for undefined quality. Undefined quality
		/// are qualities that could be addressed by this filter but is not well
		/// defined for the particular geometry of cell in question, e.g. a
		/// volume query for a triangle. Undefined quality will always be undefined.
		/// The default value for UndefinedQuality is -1.
		/// </summary>
		// Token: 0x06017CBA RID: 97466 RVA: 0x00215983 File Offset: 0x00213B83
		public virtual void SetUndefinedQuality(double _arg)
		{
			vtkCellQuality.vtkCellQuality_SetUndefinedQuality_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06017CBB RID: 97467
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellQuality_SetUnsupportedGeometry_44(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the return value for unsupported geometry. Unsupported geometry
		/// are geometries that are not supported by this filter currently, future
		/// implementation might include support for them. The default value for
		/// UnsupportedGeometry is -1.
		/// </summary>
		// Token: 0x06017CBC RID: 97468 RVA: 0x00215993 File Offset: 0x00213B93
		public virtual void SetUnsupportedGeometry(double _arg)
		{
			vtkCellQuality.vtkCellQuality_SetUnsupportedGeometry_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06017CBD RID: 97469
		[DllImport("Kitware.VTK.FiltersVerdict.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellQuality_TriangleStripArea_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the return value for undefined quality. Undefined quality
		/// are qualities that could be addressed by this filter but is not well
		/// defined for the particular geometry of cell in question, e.g. a
		/// volume query for a triangle. Undefined quality will always be undefined.
		/// The default value for UndefinedQuality is -1.
		/// </summary>
		// Token: 0x06017CBE RID: 97470 RVA: 0x002159A4 File Offset: 0x00213BA4
		public double TriangleStripArea(vtkCell arg0)
		{
			return vtkCellQuality.vtkCellQuality_TriangleStripArea_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7B RID: 6779
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellQuality";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A7C RID: 6780
		public new static readonly string MRClassNameKey = "class vtkCellQuality";
	}
}
