using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDiscreteMarchingCubes
	/// </summary>
	/// <remarks>
	///    generate object boundaries from
	/// labelled volumes
	///
	/// This filter extracts object boundaries from label maps (label maps are
	/// volumes in which each voxel is labeled according to the region in which it
	/// is contained).  The filter takes as input a volume (e.g., 3D structured
	/// point set) of segmentation labels and generates on output one or more
	/// models representing the boundaries between the specified label and the
	/// adjacent structures.  One or more label values must be specified to
	/// generate the models.  The boundary positions are always defined to be
	/// half-way between adjacent voxels. This filter works best with integral
	/// scalar values.
	///
	/// If ComputeScalars is on (the default), each output cell will have cell
	/// data that corresponding to the scalar value (segmentation label) of the
	/// corresponding cube. Note that this differs from vtkMarchingCubes, which
	/// stores the scalar value as point data. The rationale for this difference
	/// is that cell vertices may be shared between multiple cells. This also
	/// means that the resultant polydata may be non-manifold (cell faces may be
	/// coincident). To further process the polydata, users should either: 1)
	/// extract cells that have a common scalar value using vtkThreshold, or 2)
	/// process the data with filters that can handle non-manifold polydata
	/// (e.g. vtkWindowedSincPolyDataFilter). Also note, Normals and Gradients are
	/// not computed.
	///
	/// If ComputeAdjacentScalars is on (default is off), each output point will
	/// have point data that contains the label value of the neighbouring voxel.
	/// This allows to remove regions of the resulting vtkPolyData that are
	/// adjacent to specific label meshes. For example, if the input is a label
	/// image that was created by running a watershed transformation on a distance
	/// map followed by masking with the original binary segmentation. For further
	/// details and images see the VTK Journal paper:
	/// "Providing values of adjacent voxel with vtkDiscreteMarchingCubes"
	/// by Roman Grothausmann:
	/// http://hdl.handle.net/10380/3559
	/// http://www.vtkjournal.org/browse/publication/975
	///
	/// @warning
	/// This filter is specialized to volumes. If you are interested in contouring
	/// other types of data, use the general vtkContourFilter. If you want to
	/// contour an image (i.e., a volume slice), use vtFlyingEdges2D or
	/// vtkMarchingSquares.
	///
	/// @warning
	/// See also vtkPackLabels which is a utility class for renumbering the labels
	/// found in the input segmentation mask to contiguous forms of smaller type.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSurfaceNets3D vtkDiscreteFlyingEdges3D vtkSurfaceNets2D
	/// vtkContourFilter vtkSliceCubes vtkMarchingSquares vtkDividingCubes
	/// vtkPackLabels
	/// </seealso>
	// Token: 0x02000898 RID: 2200
	public class vtkDiscreteMarchingCubes : vtkMarchingCubes
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016DAB RID: 93611 RVA: 0x00201DF8 File Offset: 0x001FFFF8
		static vtkDiscreteMarchingCubes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDiscreteMarchingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDiscreteMarchingCubes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016DAC RID: 93612 RVA: 0x00201E20 File Offset: 0x00200020
		public vtkDiscreteMarchingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016DAD RID: 93613
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteMarchingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DAE RID: 93614 RVA: 0x00201E30 File Offset: 0x00200030
		public new static vtkDiscreteMarchingCubes New()
		{
			vtkDiscreteMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DAF RID: 93615 RVA: 0x00201E84 File Offset: 0x00200084
		public vtkDiscreteMarchingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016DB0 RID: 93616 RVA: 0x00201EC8 File Offset: 0x002000C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016DB1 RID: 93617
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of neighbouring voxel values.
		/// </summary>
		// Token: 0x06016DB2 RID: 93618 RVA: 0x00201ED3 File Offset: 0x002000D3
		public virtual void ComputeAdjacentScalarsOff()
		{
			vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOff_01(base.GetCppThis());
		}

		// Token: 0x06016DB3 RID: 93619
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of neighbouring voxel values.
		/// </summary>
		// Token: 0x06016DB4 RID: 93620 RVA: 0x00201EE2 File Offset: 0x002000E2
		public virtual void ComputeAdjacentScalarsOn()
		{
			vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_ComputeAdjacentScalarsOn_02(base.GetCppThis());
		}

		// Token: 0x06016DB5 RID: 93621
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteMarchingCubes_GetComputeAdjacentScalars_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the computation of neighbouring voxel values.
		/// </summary>
		// Token: 0x06016DB6 RID: 93622 RVA: 0x00201EF4 File Offset: 0x002000F4
		public virtual int GetComputeAdjacentScalars()
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_GetComputeAdjacentScalars_03(base.GetCppThis());
		}

		// Token: 0x06016DB7 RID: 93623
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DB8 RID: 93624 RVA: 0x00201F14 File Offset: 0x00200114
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06016DB9 RID: 93625
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DBA RID: 93626 RVA: 0x00201F34 File Offset: 0x00200134
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06016DBB RID: 93627
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteMarchingCubes_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DBC RID: 93628 RVA: 0x00201F50 File Offset: 0x00200150
		public override int IsA(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06016DBD RID: 93629
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDiscreteMarchingCubes_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DBE RID: 93630 RVA: 0x00201F70 File Offset: 0x00200170
		public new static int IsTypeOf(string type)
		{
			return vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_IsTypeOf_07(type);
		}

		// Token: 0x06016DBF RID: 93631
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteMarchingCubes_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DC0 RID: 93632 RVA: 0x00201F8C File Offset: 0x0020018C
		public new vtkDiscreteMarchingCubes NewInstance()
		{
			vtkDiscreteMarchingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016DC1 RID: 93633
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDiscreteMarchingCubes_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and
		/// printing the state of an object.
		/// </summary>
		// Token: 0x06016DC2 RID: 93634 RVA: 0x00201FE8 File Offset: 0x002001E8
		public new static vtkDiscreteMarchingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkDiscreteMarchingCubes vtkDiscreteMarchingCubes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDiscreteMarchingCubes = (vtkDiscreteMarchingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDiscreteMarchingCubes.Register(null);
				}
			}
			return vtkDiscreteMarchingCubes;
		}

		// Token: 0x06016DC3 RID: 93635
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDiscreteMarchingCubes_SetComputeAdjacentScalars_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the computation of neighbouring voxel values.
		/// </summary>
		// Token: 0x06016DC4 RID: 93636 RVA: 0x00202067 File Offset: 0x00200267
		public virtual void SetComputeAdjacentScalars(int _arg)
		{
			vtkDiscreteMarchingCubes.vtkDiscreteMarchingCubes_SetComputeAdjacentScalars_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001991 RID: 6545
		public new const string MRFullTypeName = "Kitware.VTK.vtkDiscreteMarchingCubes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001992 RID: 6546
		public new static readonly string MRClassNameKey = "class vtkDiscreteMarchingCubes";
	}
}
