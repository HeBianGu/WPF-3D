using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRandomAttributeGenerator
	/// </summary>
	/// <remarks>
	///    generate and create random data attributes
	///
	/// vtkRandomAttributeGenerator is a filter that creates random attributes
	/// including scalars, vectors, normals, tensors, texture coordinates and/or
	/// general data arrays. These attributes can be generated as point data, cell
	/// data or general field data. The generation of each component is normalized
	/// between a user-specified minimum and maximum value.
	///
	/// This filter provides that capability to specify the data type of the
	/// attributes, the range for each of the components, and the number of
	/// components. Note, however, that this flexibility only goes so far because
	/// some attributes (e.g., normals, vectors and tensors) are fixed in the
	/// number of components, and in the case of normals and tensors, are
	/// constrained in the values that some of the components can take (i.e.,
	/// normals have magnitude one, and tensors are symmetric).
	///
	/// @warning
	/// In general this class is used for debugging or testing purposes.
	///
	/// @warning
	/// It is possible to generate multiple attributes simultaneously.
	///
	/// @warning
	/// By default, no data is generated. Make sure to enable the generation of
	/// some attributes if you want this filter to affect the output. Also note
	/// that this filter passes through input geometry, topology and attributes.
	/// Newly created attributes may replace attribute data that would have
	/// otherwise been passed through.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBrownianPoints
	/// </seealso>
	// Token: 0x020008D3 RID: 2259
	public class vtkRandomAttributeGenerator : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601753B RID: 95547 RVA: 0x0020C1DB File Offset: 0x0020A3DB
		static vtkRandomAttributeGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRandomAttributeGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomAttributeGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601753C RID: 95548 RVA: 0x0020C203 File Offset: 0x0020A403
		public vtkRandomAttributeGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601753D RID: 95549
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomAttributeGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601753E RID: 95550 RVA: 0x0020C214 File Offset: 0x0020A414
		public new static vtkRandomAttributeGenerator New()
		{
			vtkRandomAttributeGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x0601753F RID: 95551 RVA: 0x0020C268 File Offset: 0x0020A468
		public vtkRandomAttributeGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017540 RID: 95552 RVA: 0x0020C2AC File Offset: 0x0020A4AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017541 RID: 95553
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_AttributesConstantPerBlockOff_01(HandleRef pThis);

		/// <summary>
		/// Indicate that the generated attributes are
		/// constant within a block. This can be used to highlight
		/// blocks in a composite dataset.
		/// </summary>
		// Token: 0x06017542 RID: 95554 RVA: 0x0020C2B7 File Offset: 0x0020A4B7
		public virtual void AttributesConstantPerBlockOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_AttributesConstantPerBlockOff_01(base.GetCppThis());
		}

		// Token: 0x06017543 RID: 95555
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_AttributesConstantPerBlockOn_02(HandleRef pThis);

		/// <summary>
		/// Indicate that the generated attributes are
		/// constant within a block. This can be used to highlight
		/// blocks in a composite dataset.
		/// </summary>
		// Token: 0x06017544 RID: 95556 RVA: 0x0020C2C6 File Offset: 0x0020A4C6
		public virtual void AttributesConstantPerBlockOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_AttributesConstantPerBlockOn_02(base.GetCppThis());
		}

		// Token: 0x06017545 RID: 95557
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOff_03(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x06017546 RID: 95558 RVA: 0x0020C2D5 File Offset: 0x0020A4D5
		public void GenerateAllCellDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllCellDataOff_03(base.GetCppThis());
		}

		// Token: 0x06017547 RID: 95559
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllCellDataOn_04(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x06017548 RID: 95560 RVA: 0x0020C2E4 File Offset: 0x0020A4E4
		public void GenerateAllCellDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllCellDataOn_04(base.GetCppThis());
		}

		// Token: 0x06017549 RID: 95561
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOff_05(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x0601754A RID: 95562 RVA: 0x0020C2F3 File Offset: 0x0020A4F3
		public void GenerateAllDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllDataOff_05(base.GetCppThis());
		}

		// Token: 0x0601754B RID: 95563
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllDataOn_06(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x0601754C RID: 95564 RVA: 0x0020C302 File Offset: 0x0020A502
		public void GenerateAllDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllDataOn_06(base.GetCppThis());
		}

		// Token: 0x0601754D RID: 95565
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOff_07(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x0601754E RID: 95566 RVA: 0x0020C311 File Offset: 0x0020A511
		public void GenerateAllPointDataOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllPointDataOff_07(base.GetCppThis());
		}

		// Token: 0x0601754F RID: 95567
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateAllPointDataOn_08(HandleRef pThis);

		/// <summary>
		/// Convenience methods for generating data: all data, all point data, or all cell data.
		/// For example, if all data is enabled, then all point, cell and field data is generated.
		/// If all point data is enabled, then point scalars, vectors, normals, tensors, tcoords,
		/// and a data array are produced.
		/// </summary>
		// Token: 0x06017550 RID: 95568 RVA: 0x0020C320 File Offset: 0x0020A520
		public void GenerateAllPointDataOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateAllPointDataOn_08(base.GetCppThis());
		}

		// Token: 0x06017551 RID: 95569
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOff_09(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary cell array is to be generated. The array is
		/// added to the cell data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates array (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x06017552 RID: 95570 RVA: 0x0020C32F File Offset: 0x0020A52F
		public virtual void GenerateCellArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellArrayOff_09(base.GetCppThis());
		}

		// Token: 0x06017553 RID: 95571
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellArrayOn_10(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary cell array is to be generated. The array is
		/// added to the cell data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates array (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x06017554 RID: 95572 RVA: 0x0020C33E File Offset: 0x0020A53E
		public virtual void GenerateCellArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellArrayOn_10(base.GetCppThis());
		}

		// Token: 0x06017555 RID: 95573
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOff_11(HandleRef pThis);

		/// <summary>
		/// Indicate that cell normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017556 RID: 95574 RVA: 0x0020C34D File Offset: 0x0020A54D
		public virtual void GenerateCellNormalsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellNormalsOff_11(base.GetCppThis());
		}

		// Token: 0x06017557 RID: 95575
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellNormalsOn_12(HandleRef pThis);

		/// <summary>
		/// Indicate that cell normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017558 RID: 95576 RVA: 0x0020C35C File Offset: 0x0020A55C
		public virtual void GenerateCellNormalsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellNormalsOn_12(base.GetCppThis());
		}

		// Token: 0x06017559 RID: 95577
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOff_13(HandleRef pThis);

		/// <summary>
		/// Indicate that cell scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601755A RID: 95578 RVA: 0x0020C36B File Offset: 0x0020A56B
		public virtual void GenerateCellScalarsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellScalarsOff_13(base.GetCppThis());
		}

		// Token: 0x0601755B RID: 95579
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellScalarsOn_14(HandleRef pThis);

		/// <summary>
		/// Indicate that cell scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601755C RID: 95580 RVA: 0x0020C37A File Offset: 0x0020A57A
		public virtual void GenerateCellScalarsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellScalarsOn_14(base.GetCppThis());
		}

		// Token: 0x0601755D RID: 95581
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOff_15(HandleRef pThis);

		/// <summary>
		/// Indicate that cell texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x0601755E RID: 95582 RVA: 0x0020C389 File Offset: 0x0020A589
		public virtual void GenerateCellTCoordsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTCoordsOff_15(base.GetCppThis());
		}

		// Token: 0x0601755F RID: 95583
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTCoordsOn_16(HandleRef pThis);

		/// <summary>
		/// Indicate that cell texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x06017560 RID: 95584 RVA: 0x0020C398 File Offset: 0x0020A598
		public virtual void GenerateCellTCoordsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTCoordsOn_16(base.GetCppThis());
		}

		// Token: 0x06017561 RID: 95585
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOff_17(HandleRef pThis);

		/// <summary>
		/// Indicate that cell tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x06017562 RID: 95586 RVA: 0x0020C3A7 File Offset: 0x0020A5A7
		public virtual void GenerateCellTensorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTensorsOff_17(base.GetCppThis());
		}

		// Token: 0x06017563 RID: 95587
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellTensorsOn_18(HandleRef pThis);

		/// <summary>
		/// Indicate that cell tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x06017564 RID: 95588 RVA: 0x0020C3B6 File Offset: 0x0020A5B6
		public virtual void GenerateCellTensorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellTensorsOn_18(base.GetCppThis());
		}

		// Token: 0x06017565 RID: 95589
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOff_19(HandleRef pThis);

		/// <summary>
		/// Indicate that cell vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017566 RID: 95590 RVA: 0x0020C3C5 File Offset: 0x0020A5C5
		public virtual void GenerateCellVectorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellVectorsOff_19(base.GetCppThis());
		}

		// Token: 0x06017567 RID: 95591
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateCellVectorsOn_20(HandleRef pThis);

		/// <summary>
		/// Indicate that cell vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017568 RID: 95592 RVA: 0x0020C3D4 File Offset: 0x0020A5D4
		public virtual void GenerateCellVectorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateCellVectorsOn_20(base.GetCppThis());
		}

		// Token: 0x06017569 RID: 95593
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOff_21(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary field data array is to be generated. Note
		/// that the specified number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601756A RID: 95594 RVA: 0x0020C3E3 File Offset: 0x0020A5E3
		public virtual void GenerateFieldArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateFieldArrayOff_21(base.GetCppThis());
		}

		// Token: 0x0601756B RID: 95595
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GenerateFieldArrayOn_22(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary field data array is to be generated. Note
		/// that the specified number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601756C RID: 95596 RVA: 0x0020C3F2 File Offset: 0x0020A5F2
		public virtual void GenerateFieldArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GenerateFieldArrayOn_22(base.GetCppThis());
		}

		// Token: 0x0601756D RID: 95597
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOff_23(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary point array is to be generated. The array is
		/// added to the points data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x0601756E RID: 95598 RVA: 0x0020C401 File Offset: 0x0020A601
		public virtual void GeneratePointArrayOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointArrayOff_23(base.GetCppThis());
		}

		// Token: 0x0601756F RID: 95599
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointArrayOn_24(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary point array is to be generated. The array is
		/// added to the points data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x06017570 RID: 95600 RVA: 0x0020C410 File Offset: 0x0020A610
		public virtual void GeneratePointArrayOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointArrayOn_24(base.GetCppThis());
		}

		// Token: 0x06017571 RID: 95601
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOff_25(HandleRef pThis);

		/// <summary>
		/// Indicate that point normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017572 RID: 95602 RVA: 0x0020C41F File Offset: 0x0020A61F
		public virtual void GeneratePointNormalsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointNormalsOff_25(base.GetCppThis());
		}

		// Token: 0x06017573 RID: 95603
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointNormalsOn_26(HandleRef pThis);

		/// <summary>
		/// Indicate that point normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017574 RID: 95604 RVA: 0x0020C42E File Offset: 0x0020A62E
		public virtual void GeneratePointNormalsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointNormalsOn_26(base.GetCppThis());
		}

		// Token: 0x06017575 RID: 95605
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOff_27(HandleRef pThis);

		/// <summary>
		/// Indicate that point scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x06017576 RID: 95606 RVA: 0x0020C43D File Offset: 0x0020A63D
		public virtual void GeneratePointScalarsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointScalarsOff_27(base.GetCppThis());
		}

		// Token: 0x06017577 RID: 95607
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointScalarsOn_28(HandleRef pThis);

		/// <summary>
		/// Indicate that point scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x06017578 RID: 95608 RVA: 0x0020C44C File Offset: 0x0020A64C
		public virtual void GeneratePointScalarsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointScalarsOn_28(base.GetCppThis());
		}

		// Token: 0x06017579 RID: 95609
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOff_29(HandleRef pThis);

		/// <summary>
		/// Indicate that point texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x0601757A RID: 95610 RVA: 0x0020C45B File Offset: 0x0020A65B
		public virtual void GeneratePointTCoordsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTCoordsOff_29(base.GetCppThis());
		}

		// Token: 0x0601757B RID: 95611
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTCoordsOn_30(HandleRef pThis);

		/// <summary>
		/// Indicate that point texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x0601757C RID: 95612 RVA: 0x0020C46A File Offset: 0x0020A66A
		public virtual void GeneratePointTCoordsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTCoordsOn_30(base.GetCppThis());
		}

		// Token: 0x0601757D RID: 95613
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOff_31(HandleRef pThis);

		/// <summary>
		/// Indicate that point tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x0601757E RID: 95614 RVA: 0x0020C479 File Offset: 0x0020A679
		public virtual void GeneratePointTensorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTensorsOff_31(base.GetCppThis());
		}

		// Token: 0x0601757F RID: 95615
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointTensorsOn_32(HandleRef pThis);

		/// <summary>
		/// Indicate that point tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x06017580 RID: 95616 RVA: 0x0020C488 File Offset: 0x0020A688
		public virtual void GeneratePointTensorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointTensorsOn_32(base.GetCppThis());
		}

		// Token: 0x06017581 RID: 95617
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOff_33(HandleRef pThis);

		/// <summary>
		/// Indicate that point vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017582 RID: 95618 RVA: 0x0020C497 File Offset: 0x0020A697
		public virtual void GeneratePointVectorsOff()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointVectorsOff_33(base.GetCppThis());
		}

		// Token: 0x06017583 RID: 95619
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_GeneratePointVectorsOn_34(HandleRef pThis);

		/// <summary>
		/// Indicate that point vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017584 RID: 95620 RVA: 0x0020C4A6 File Offset: 0x0020A6A6
		public virtual void GeneratePointVectorsOn()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GeneratePointVectorsOn_34(base.GetCppThis());
		}

		// Token: 0x06017585 RID: 95621
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkRandomAttributeGenerator_GetAttributesConstantPerBlock_35(HandleRef pThis);

		/// <summary>
		/// Indicate that the generated attributes are
		/// constant within a block. This can be used to highlight
		/// blocks in a composite dataset.
		/// </summary>
		// Token: 0x06017586 RID: 95622 RVA: 0x0020C4B8 File Offset: 0x0020A6B8
		public virtual bool GetAttributesConstantPerBlock()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetAttributesConstantPerBlock_35(base.GetCppThis()) != 0;
		}

		// Token: 0x06017587 RID: 95623
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetDataType_36(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x06017588 RID: 95624 RVA: 0x0020C4E0 File Offset: 0x0020A6E0
		public virtual int GetDataType()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetDataType_36(base.GetCppThis());
		}

		// Token: 0x06017589 RID: 95625
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellArray_37(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary cell array is to be generated. The array is
		/// added to the cell data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates array (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x0601758A RID: 95626 RVA: 0x0020C500 File Offset: 0x0020A700
		public virtual int GetGenerateCellArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellArray_37(base.GetCppThis());
		}

		// Token: 0x0601758B RID: 95627
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellNormals_38(HandleRef pThis);

		/// <summary>
		/// Indicate that cell normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x0601758C RID: 95628 RVA: 0x0020C520 File Offset: 0x0020A720
		public virtual int GetGenerateCellNormals()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellNormals_38(base.GetCppThis());
		}

		// Token: 0x0601758D RID: 95629
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellScalars_39(HandleRef pThis);

		/// <summary>
		/// Indicate that cell scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601758E RID: 95630 RVA: 0x0020C540 File Offset: 0x0020A740
		public virtual int GetGenerateCellScalars()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellScalars_39(base.GetCppThis());
		}

		// Token: 0x0601758F RID: 95631
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTCoords_40(HandleRef pThis);

		/// <summary>
		/// Indicate that cell texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x06017590 RID: 95632 RVA: 0x0020C560 File Offset: 0x0020A760
		public virtual int GetGenerateCellTCoords()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellTCoords_40(base.GetCppThis());
		}

		// Token: 0x06017591 RID: 95633
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellTensors_41(HandleRef pThis);

		/// <summary>
		/// Indicate that cell tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x06017592 RID: 95634 RVA: 0x0020C580 File Offset: 0x0020A780
		public virtual int GetGenerateCellTensors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellTensors_41(base.GetCppThis());
		}

		// Token: 0x06017593 RID: 95635
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateCellVectors_42(HandleRef pThis);

		/// <summary>
		/// Indicate that cell vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x06017594 RID: 95636 RVA: 0x0020C5A0 File Offset: 0x0020A7A0
		public virtual int GetGenerateCellVectors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateCellVectors_42(base.GetCppThis());
		}

		// Token: 0x06017595 RID: 95637
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGenerateFieldArray_43(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary field data array is to be generated. Note
		/// that the specified number of components is used to create the scalar.
		/// </summary>
		// Token: 0x06017596 RID: 95638 RVA: 0x0020C5C0 File Offset: 0x0020A7C0
		public virtual int GetGenerateFieldArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGenerateFieldArray_43(base.GetCppThis());
		}

		// Token: 0x06017597 RID: 95639
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointArray_44(HandleRef pThis);

		/// <summary>
		/// Indicate that an arbitrary point array is to be generated. The array is
		/// added to the points data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x06017598 RID: 95640 RVA: 0x0020C5E0 File Offset: 0x0020A7E0
		public virtual int GetGeneratePointArray()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointArray_44(base.GetCppThis());
		}

		// Token: 0x06017599 RID: 95641
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointNormals_45(HandleRef pThis);

		/// <summary>
		/// Indicate that point normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x0601759A RID: 95642 RVA: 0x0020C600 File Offset: 0x0020A800
		public virtual int GetGeneratePointNormals()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointNormals_45(base.GetCppThis());
		}

		// Token: 0x0601759B RID: 95643
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointScalars_46(HandleRef pThis);

		/// <summary>
		/// Indicate that point scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x0601759C RID: 95644 RVA: 0x0020C620 File Offset: 0x0020A820
		public virtual int GetGeneratePointScalars()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointScalars_46(base.GetCppThis());
		}

		// Token: 0x0601759D RID: 95645
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTCoords_47(HandleRef pThis);

		/// <summary>
		/// Indicate that point texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x0601759E RID: 95646 RVA: 0x0020C640 File Offset: 0x0020A840
		public virtual int GetGeneratePointTCoords()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointTCoords_47(base.GetCppThis());
		}

		// Token: 0x0601759F RID: 95647
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointTensors_48(HandleRef pThis);

		/// <summary>
		/// Indicate that point tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x060175A0 RID: 95648 RVA: 0x0020C660 File Offset: 0x0020A860
		public virtual int GetGeneratePointTensors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointTensors_48(base.GetCppThis());
		}

		// Token: 0x060175A1 RID: 95649
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetGeneratePointVectors_49(HandleRef pThis);

		/// <summary>
		/// Indicate that point vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x060175A2 RID: 95650 RVA: 0x0020C680 File Offset: 0x0020A880
		public virtual int GetGeneratePointVectors()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetGeneratePointVectors_49(base.GetCppThis());
		}

		// Token: 0x060175A3 RID: 95651
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomAttributeGenerator_GetMaximumComponentValue_50(HandleRef pThis);

		/// <summary>
		/// Set the maximum component value. This applies to all data that is generated,
		/// although normals and tensors have internal constraints that must be
		/// observed.
		/// </summary>
		// Token: 0x060175A4 RID: 95652 RVA: 0x0020C6A0 File Offset: 0x0020A8A0
		public virtual double GetMaximumComponentValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetMaximumComponentValue_50(base.GetCppThis());
		}

		// Token: 0x060175A5 RID: 95653
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRandomAttributeGenerator_GetMinimumComponentValue_51(HandleRef pThis);

		/// <summary>
		/// Set the minimum component value. This applies to all data that is generated,
		/// although normals and tensors have internal constraints that must be
		/// observed.
		/// </summary>
		// Token: 0x060175A6 RID: 95654 RVA: 0x0020C6C0 File Offset: 0x0020A8C0
		public virtual double GetMinimumComponentValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetMinimumComponentValue_51(base.GetCppThis());
		}

		// Token: 0x060175A7 RID: 95655
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponents_52(HandleRef pThis);

		/// <summary>
		/// Specify the number of components to generate. This value only applies to those
		/// attribute types that take a variable number of components. For example, a vector
		/// is only three components so the number of components is not applicable; whereas
		/// a scalar may support multiple, varying number of components.
		/// </summary>
		// Token: 0x060175A8 RID: 95656 RVA: 0x0020C6E0 File Offset: 0x0020A8E0
		public virtual int GetNumberOfComponents()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponents_52(base.GetCppThis());
		}

		// Token: 0x060175A9 RID: 95657
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_53(HandleRef pThis);

		/// <summary>
		/// Specify the number of components to generate. This value only applies to those
		/// attribute types that take a variable number of components. For example, a vector
		/// is only three components so the number of components is not applicable; whereas
		/// a scalar may support multiple, varying number of components.
		/// </summary>
		// Token: 0x060175AA RID: 95658 RVA: 0x0020C700 File Offset: 0x0020A900
		public virtual int GetNumberOfComponentsMaxValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponentsMaxValue_53(base.GetCppThis());
		}

		// Token: 0x060175AB RID: 95659
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_54(HandleRef pThis);

		/// <summary>
		/// Specify the number of components to generate. This value only applies to those
		/// attribute types that take a variable number of components. For example, a vector
		/// is only three components so the number of components is not applicable; whereas
		/// a scalar may support multiple, varying number of components.
		/// </summary>
		// Token: 0x060175AC RID: 95660 RVA: 0x0020C720 File Offset: 0x0020A920
		public virtual int GetNumberOfComponentsMinValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfComponentsMinValue_54(base.GetCppThis());
		}

		// Token: 0x060175AD RID: 95661
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBase_55(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175AE RID: 95662 RVA: 0x0020C740 File Offset: 0x0020A940
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBase_55(base.GetCppThis(), type);
		}

		// Token: 0x060175AF RID: 95663
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBaseType_56([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175B0 RID: 95664 RVA: 0x0020C760 File Offset: 0x0020A960
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfGenerationsFromBaseType_56(type);
		}

		// Token: 0x060175B1 RID: 95665
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuples_57(HandleRef pThis);

		/// <summary>
		/// Specify the number of tuples to generate. This value only applies when creating
		/// general field data. In all other cases (i.e., point data or cell data), the number
		/// of tuples is controlled by the number of points and cells, respectively.
		/// </summary>
		// Token: 0x060175B2 RID: 95666 RVA: 0x0020C77C File Offset: 0x0020A97C
		public virtual long GetNumberOfTuples()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuples_57(base.GetCppThis());
		}

		// Token: 0x060175B3 RID: 95667
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_58(HandleRef pThis);

		/// <summary>
		/// Specify the number of tuples to generate. This value only applies when creating
		/// general field data. In all other cases (i.e., point data or cell data), the number
		/// of tuples is controlled by the number of points and cells, respectively.
		/// </summary>
		// Token: 0x060175B4 RID: 95668 RVA: 0x0020C79C File Offset: 0x0020A99C
		public virtual long GetNumberOfTuplesMaxValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuplesMaxValue_58(base.GetCppThis());
		}

		// Token: 0x060175B5 RID: 95669
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_59(HandleRef pThis);

		/// <summary>
		/// Specify the number of tuples to generate. This value only applies when creating
		/// general field data. In all other cases (i.e., point data or cell data), the number
		/// of tuples is controlled by the number of points and cells, respectively.
		/// </summary>
		// Token: 0x060175B6 RID: 95670 RVA: 0x0020C7BC File Offset: 0x0020A9BC
		public virtual long GetNumberOfTuplesMinValue()
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_GetNumberOfTuplesMinValue_59(base.GetCppThis());
		}

		// Token: 0x060175B7 RID: 95671
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_IsA_60(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175B8 RID: 95672 RVA: 0x0020C7DC File Offset: 0x0020A9DC
		public override int IsA(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_IsA_60(base.GetCppThis(), type);
		}

		// Token: 0x060175B9 RID: 95673
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRandomAttributeGenerator_IsTypeOf_61([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175BA RID: 95674 RVA: 0x0020C7FC File Offset: 0x0020A9FC
		public new static int IsTypeOf(string type)
		{
			return vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_IsTypeOf_61(type);
		}

		// Token: 0x060175BB RID: 95675
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomAttributeGenerator_NewInstance_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175BC RID: 95676 RVA: 0x0020C818 File Offset: 0x0020AA18
		public new vtkRandomAttributeGenerator NewInstance()
		{
			vtkRandomAttributeGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_NewInstance_63(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060175BD RID: 95677
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRandomAttributeGenerator_SafeDownCast_64(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type info, and printing.
		/// </summary>
		// Token: 0x060175BE RID: 95678 RVA: 0x0020C874 File Offset: 0x0020AA74
		public new static vtkRandomAttributeGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkRandomAttributeGenerator vtkRandomAttributeGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SafeDownCast_64((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRandomAttributeGenerator = (vtkRandomAttributeGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRandomAttributeGenerator.Register(null);
				}
			}
			return vtkRandomAttributeGenerator;
		}

		// Token: 0x060175BF RID: 95679
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetAttributesConstantPerBlock_65(HandleRef pThis, byte _arg);

		/// <summary>
		/// Indicate that the generated attributes are
		/// constant within a block. This can be used to highlight
		/// blocks in a composite dataset.
		/// </summary>
		// Token: 0x060175C0 RID: 95680 RVA: 0x0020C8F3 File Offset: 0x0020AAF3
		public virtual void SetAttributesConstantPerBlock(bool _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetAttributesConstantPerBlock_65(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060175C1 RID: 95681
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetComponentRange_66(HandleRef pThis, double minimumValue, double maximumValue);

		/// <summary>
		/// Set the minimum component value. This applies to all data that is generated,
		/// although normals and tensors have internal constraints that must be
		/// observed.
		/// </summary>
		// Token: 0x060175C2 RID: 95682 RVA: 0x0020C90B File Offset: 0x0020AB0B
		public void SetComponentRange(double minimumValue, double maximumValue)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetComponentRange_66(base.GetCppThis(), minimumValue, maximumValue);
		}

		// Token: 0x060175C3 RID: 95683
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataType_67(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175C4 RID: 95684 RVA: 0x0020C91C File Offset: 0x0020AB1C
		public virtual void SetDataType(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataType_67(base.GetCppThis(), _arg);
		}

		// Token: 0x060175C5 RID: 95685
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToBit_68(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175C6 RID: 95686 RVA: 0x0020C92C File Offset: 0x0020AB2C
		public void SetDataTypeToBit()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToBit_68(base.GetCppThis());
		}

		// Token: 0x060175C7 RID: 95687
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToChar_69(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175C8 RID: 95688 RVA: 0x0020C93B File Offset: 0x0020AB3B
		public void SetDataTypeToChar()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToChar_69(base.GetCppThis());
		}

		// Token: 0x060175C9 RID: 95689
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToDouble_70(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175CA RID: 95690 RVA: 0x0020C94A File Offset: 0x0020AB4A
		public void SetDataTypeToDouble()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToDouble_70(base.GetCppThis());
		}

		// Token: 0x060175CB RID: 95691
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToFloat_71(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175CC RID: 95692 RVA: 0x0020C959 File Offset: 0x0020AB59
		public void SetDataTypeToFloat()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToFloat_71(base.GetCppThis());
		}

		// Token: 0x060175CD RID: 95693
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToIdType_72(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175CE RID: 95694 RVA: 0x0020C968 File Offset: 0x0020AB68
		public void SetDataTypeToIdType()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToIdType_72(base.GetCppThis());
		}

		// Token: 0x060175CF RID: 95695
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToInt_73(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175D0 RID: 95696 RVA: 0x0020C977 File Offset: 0x0020AB77
		public void SetDataTypeToInt()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToInt_73(base.GetCppThis());
		}

		// Token: 0x060175D1 RID: 95697
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToLong_74(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175D2 RID: 95698 RVA: 0x0020C986 File Offset: 0x0020AB86
		public void SetDataTypeToLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToLong_74(base.GetCppThis());
		}

		// Token: 0x060175D3 RID: 95699
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToLongLong_75(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175D4 RID: 95700 RVA: 0x0020C995 File Offset: 0x0020AB95
		public void SetDataTypeToLongLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToLongLong_75(base.GetCppThis());
		}

		// Token: 0x060175D5 RID: 95701
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToShort_76(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175D6 RID: 95702 RVA: 0x0020C9A4 File Offset: 0x0020ABA4
		public void SetDataTypeToShort()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToShort_76(base.GetCppThis());
		}

		// Token: 0x060175D7 RID: 95703
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_77(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175D8 RID: 95704 RVA: 0x0020C9B3 File Offset: 0x0020ABB3
		public void SetDataTypeToUnsignedChar()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedChar_77(base.GetCppThis());
		}

		// Token: 0x060175D9 RID: 95705
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_78(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175DA RID: 95706 RVA: 0x0020C9C2 File Offset: 0x0020ABC2
		public void SetDataTypeToUnsignedInt()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedInt_78(base.GetCppThis());
		}

		// Token: 0x060175DB RID: 95707
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_79(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175DC RID: 95708 RVA: 0x0020C9D1 File Offset: 0x0020ABD1
		public void SetDataTypeToUnsignedLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedLong_79(base.GetCppThis());
		}

		// Token: 0x060175DD RID: 95709
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedLongLong_80(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175DE RID: 95710 RVA: 0x0020C9E0 File Offset: 0x0020ABE0
		public void SetDataTypeToUnsignedLongLong()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedLongLong_80(base.GetCppThis());
		}

		// Token: 0x060175DF RID: 95711
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_81(HandleRef pThis);

		/// <summary>
		/// Specify the type of array to create (all components of this array are of this
		/// type). This holds true for all arrays that are created.
		/// </summary>
		// Token: 0x060175E0 RID: 95712 RVA: 0x0020C9EF File Offset: 0x0020ABEF
		public void SetDataTypeToUnsignedShort()
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetDataTypeToUnsignedShort_81(base.GetCppThis());
		}

		// Token: 0x060175E1 RID: 95713
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellArray_82(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that an arbitrary cell array is to be generated. The array is
		/// added to the cell data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates array (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x060175E2 RID: 95714 RVA: 0x0020C9FE File Offset: 0x0020ABFE
		public virtual void SetGenerateCellArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellArray_82(base.GetCppThis(), _arg);
		}

		// Token: 0x060175E3 RID: 95715
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellNormals_83(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that cell normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x060175E4 RID: 95716 RVA: 0x0020CA0E File Offset: 0x0020AC0E
		public virtual void SetGenerateCellNormals(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellNormals_83(base.GetCppThis(), _arg);
		}

		// Token: 0x060175E5 RID: 95717
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellScalars_84(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that cell scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x060175E6 RID: 95718 RVA: 0x0020CA1E File Offset: 0x0020AC1E
		public virtual void SetGenerateCellScalars(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellScalars_84(base.GetCppThis(), _arg);
		}

		// Token: 0x060175E7 RID: 95719
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTCoords_85(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that cell texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x060175E8 RID: 95720 RVA: 0x0020CA2E File Offset: 0x0020AC2E
		public virtual void SetGenerateCellTCoords(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellTCoords_85(base.GetCppThis(), _arg);
		}

		// Token: 0x060175E9 RID: 95721
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellTensors_86(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that cell tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x060175EA RID: 95722 RVA: 0x0020CA3E File Offset: 0x0020AC3E
		public virtual void SetGenerateCellTensors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellTensors_86(base.GetCppThis(), _arg);
		}

		// Token: 0x060175EB RID: 95723
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateCellVectors_87(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that cell vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x060175EC RID: 95724 RVA: 0x0020CA4E File Offset: 0x0020AC4E
		public virtual void SetGenerateCellVectors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateCellVectors_87(base.GetCppThis(), _arg);
		}

		// Token: 0x060175ED RID: 95725
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGenerateFieldArray_88(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that an arbitrary field data array is to be generated. Note
		/// that the specified number of components is used to create the scalar.
		/// </summary>
		// Token: 0x060175EE RID: 95726 RVA: 0x0020CA5E File Offset: 0x0020AC5E
		public virtual void SetGenerateFieldArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGenerateFieldArray_88(base.GetCppThis(), _arg);
		}

		// Token: 0x060175EF RID: 95727
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointArray_89(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that an arbitrary point array is to be generated. The array is
		/// added to the points data but is not labeled as one of scalars, vectors,
		/// normals, tensors, or texture coordinates (i.e., AddArray() is
		/// used). Note that the specified number of components is used to create
		/// the array.
		/// </summary>
		// Token: 0x060175F0 RID: 95728 RVA: 0x0020CA6E File Offset: 0x0020AC6E
		public virtual void SetGeneratePointArray(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointArray_89(base.GetCppThis(), _arg);
		}

		// Token: 0x060175F1 RID: 95729
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointNormals_90(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that point normals are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x060175F2 RID: 95730 RVA: 0x0020CA7E File Offset: 0x0020AC7E
		public virtual void SetGeneratePointNormals(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointNormals_90(base.GetCppThis(), _arg);
		}

		// Token: 0x060175F3 RID: 95731
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointScalars_91(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that point scalars are to be generated. Note that the specified
		/// number of components is used to create the scalar.
		/// </summary>
		// Token: 0x060175F4 RID: 95732 RVA: 0x0020CA8E File Offset: 0x0020AC8E
		public virtual void SetGeneratePointScalars(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointScalars_91(base.GetCppThis(), _arg);
		}

		// Token: 0x060175F5 RID: 95733
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTCoords_92(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that point texture coordinates are to be generated. Note that
		/// the specified number of components is used to create the texture
		/// coordinates (but must range between one and three).
		/// </summary>
		// Token: 0x060175F6 RID: 95734 RVA: 0x0020CA9E File Offset: 0x0020AC9E
		public virtual void SetGeneratePointTCoords(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointTCoords_92(base.GetCppThis(), _arg);
		}

		// Token: 0x060175F7 RID: 95735
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointTensors_93(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that point tensors are to be generated. Note that the
		/// number of components is always equal to nine.
		/// </summary>
		// Token: 0x060175F8 RID: 95736 RVA: 0x0020CAAE File Offset: 0x0020ACAE
		public virtual void SetGeneratePointTensors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointTensors_93(base.GetCppThis(), _arg);
		}

		// Token: 0x060175F9 RID: 95737
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetGeneratePointVectors_94(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate that point vectors are to be generated. Note that the
		/// number of components is always equal to three.
		/// </summary>
		// Token: 0x060175FA RID: 95738 RVA: 0x0020CABE File Offset: 0x0020ACBE
		public virtual void SetGeneratePointVectors(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetGeneratePointVectors_94(base.GetCppThis(), _arg);
		}

		// Token: 0x060175FB RID: 95739
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetMaximumComponentValue_95(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum component value. This applies to all data that is generated,
		/// although normals and tensors have internal constraints that must be
		/// observed.
		/// </summary>
		// Token: 0x060175FC RID: 95740 RVA: 0x0020CACE File Offset: 0x0020ACCE
		public virtual void SetMaximumComponentValue(double _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetMaximumComponentValue_95(base.GetCppThis(), _arg);
		}

		// Token: 0x060175FD RID: 95741
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetMinimumComponentValue_96(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the minimum component value. This applies to all data that is generated,
		/// although normals and tensors have internal constraints that must be
		/// observed.
		/// </summary>
		// Token: 0x060175FE RID: 95742 RVA: 0x0020CADE File Offset: 0x0020ACDE
		public virtual void SetMinimumComponentValue(double _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetMinimumComponentValue_96(base.GetCppThis(), _arg);
		}

		// Token: 0x060175FF RID: 95743
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetNumberOfComponents_97(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of components to generate. This value only applies to those
		/// attribute types that take a variable number of components. For example, a vector
		/// is only three components so the number of components is not applicable; whereas
		/// a scalar may support multiple, varying number of components.
		/// </summary>
		// Token: 0x06017600 RID: 95744 RVA: 0x0020CAEE File Offset: 0x0020ACEE
		public virtual void SetNumberOfComponents(int _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetNumberOfComponents_97(base.GetCppThis(), _arg);
		}

		// Token: 0x06017601 RID: 95745
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRandomAttributeGenerator_SetNumberOfTuples_98(HandleRef pThis, long _arg);

		/// <summary>
		/// Specify the number of tuples to generate. This value only applies when creating
		/// general field data. In all other cases (i.e., point data or cell data), the number
		/// of tuples is controlled by the number of points and cells, respectively.
		/// </summary>
		// Token: 0x06017602 RID: 95746 RVA: 0x0020CAFE File Offset: 0x0020ACFE
		public virtual void SetNumberOfTuples(long _arg)
		{
			vtkRandomAttributeGenerator.vtkRandomAttributeGenerator_SetNumberOfTuples_98(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A19 RID: 6681
		public new const string MRFullTypeName = "Kitware.VTK.vtkRandomAttributeGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A1A RID: 6682
		public new static readonly string MRClassNameKey = "class vtkRandomAttributeGenerator";
	}
}
