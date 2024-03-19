using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractTensorComponents
	/// </summary>
	/// <remarks>
	///    extract parts of tensor and create a scalar, vector, normal, or texture coordinates.
	///
	/// vtkExtractTensorComponents is a filter that extracts components of a
	/// tensor to create a scalar, vector, normal, and/or texture coords. For
	/// example, if the tensor contains components of stress, then you could
	/// extract the normal stress in the x-direction as a scalar (i.e., tensor
	/// component (0,0)).
	///
	/// To use this filter, you must set some boolean flags to control
	/// which data is extracted from the tensors, and whether you want to
	/// pass the tensor data through to the output. Also, you must specify
	/// the tensor component(s) for each type of data you want to
	/// extract. The tensor component(s) is(are) specified using matrix notation
	/// into a 3x3 matrix. That is, use the (row,column) address to specify
	/// a particular tensor component; and if the data you are extracting
	/// requires more than one component, use a list of addresses. (Note
	/// that the addresses are 0-offset -&gt; (0,0) specifies the upper left
	/// corner of the tensor.)
	///
	/// There are two optional methods to extract scalar data. You can
	/// extract the determinant of the tensor, or you can extract the
	/// effective stress of the tensor. These require that the ivar
	/// ExtractScalars is on, and the appropriate scalar extraction mode is
	/// set.
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorWidget vtkTensorGlyph vtkPointSmoothingFilter
	/// vtkHyperStreamline
	/// </seealso>
	// Token: 0x020006B9 RID: 1721
	public class vtkExtractTensorComponents : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601259F RID: 75167 RVA: 0x0019B9AB File Offset: 0x00199BAB
		static vtkExtractTensorComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractTensorComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTensorComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060125A0 RID: 75168 RVA: 0x0019B9D3 File Offset: 0x00199BD3
		public vtkExtractTensorComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060125A1 RID: 75169
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object to extract nothing and to not pass tensor data
		/// through the pipeline.
		/// </summary>
		// Token: 0x060125A2 RID: 75170 RVA: 0x0019B9E4 File Offset: 0x00199BE4
		public new static vtkExtractTensorComponents New()
		{
			vtkExtractTensorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object to extract nothing and to not pass tensor data
		/// through the pipeline.
		/// </summary>
		// Token: 0x060125A3 RID: 75171 RVA: 0x0019BA38 File Offset: 0x00199C38
		public vtkExtractTensorComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractTensorComponents.vtkExtractTensorComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060125A4 RID: 75172 RVA: 0x0019BA7C File Offset: 0x00199C7C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060125A5 RID: 75173
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractNormalsOff_01(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal data is extracted from tensor.
		/// </summary>
		// Token: 0x060125A6 RID: 75174 RVA: 0x0019BA87 File Offset: 0x00199C87
		public virtual void ExtractNormalsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractNormalsOff_01(base.GetCppThis());
		}

		// Token: 0x060125A7 RID: 75175
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractNormalsOn_02(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal data is extracted from tensor.
		/// </summary>
		// Token: 0x060125A8 RID: 75176 RVA: 0x0019BA96 File Offset: 0x00199C96
		public virtual void ExtractNormalsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractNormalsOn_02(base.GetCppThis());
		}

		// Token: 0x060125A9 RID: 75177
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractScalarsOff_03(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether scalar data is extracted from the tensors.
		/// </summary>
		// Token: 0x060125AA RID: 75178 RVA: 0x0019BAA5 File Offset: 0x00199CA5
		public virtual void ExtractScalarsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractScalarsOff_03(base.GetCppThis());
		}

		// Token: 0x060125AB RID: 75179
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractScalarsOn_04(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether scalar data is extracted from the tensors.
		/// </summary>
		// Token: 0x060125AC RID: 75180 RVA: 0x0019BAB4 File Offset: 0x00199CB4
		public virtual void ExtractScalarsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractScalarsOn_04(base.GetCppThis());
		}

		// Token: 0x060125AD RID: 75181
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractTCoordsOff_05(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether texture coordinates are extracted from tensor.
		/// </summary>
		// Token: 0x060125AE RID: 75182 RVA: 0x0019BAC3 File Offset: 0x00199CC3
		public virtual void ExtractTCoordsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractTCoordsOff_05(base.GetCppThis());
		}

		// Token: 0x060125AF RID: 75183
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractTCoordsOn_06(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether texture coordinates are extracted from tensor.
		/// </summary>
		// Token: 0x060125B0 RID: 75184 RVA: 0x0019BAD2 File Offset: 0x00199CD2
		public virtual void ExtractTCoordsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractTCoordsOn_06(base.GetCppThis());
		}

		// Token: 0x060125B1 RID: 75185
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractVectorsOff_07(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vector data is extracted from tensor.
		/// </summary>
		// Token: 0x060125B2 RID: 75186 RVA: 0x0019BAE1 File Offset: 0x00199CE1
		public virtual void ExtractVectorsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractVectorsOff_07(base.GetCppThis());
		}

		// Token: 0x060125B3 RID: 75187
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ExtractVectorsOn_08(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vector data is extracted from tensor.
		/// </summary>
		// Token: 0x060125B4 RID: 75188 RVA: 0x0019BAF0 File Offset: 0x00199CF0
		public virtual void ExtractVectorsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ExtractVectorsOn_08(base.GetCppThis());
		}

		// Token: 0x060125B5 RID: 75189
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetExtractNormals_09(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal data is extracted from tensor.
		/// </summary>
		// Token: 0x060125B6 RID: 75190 RVA: 0x0019BB00 File Offset: 0x00199D00
		public virtual int GetExtractNormals()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractNormals_09(base.GetCppThis());
		}

		// Token: 0x060125B7 RID: 75191
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetExtractScalars_10(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether scalar data is extracted from the tensors.
		/// </summary>
		// Token: 0x060125B8 RID: 75192 RVA: 0x0019BB20 File Offset: 0x00199D20
		public virtual int GetExtractScalars()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractScalars_10(base.GetCppThis());
		}

		// Token: 0x060125B9 RID: 75193
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetExtractTCoords_11(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether texture coordinates are extracted from tensor.
		/// </summary>
		// Token: 0x060125BA RID: 75194 RVA: 0x0019BB40 File Offset: 0x00199D40
		public virtual int GetExtractTCoords()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractTCoords_11(base.GetCppThis());
		}

		// Token: 0x060125BB RID: 75195
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetExtractVectors_12(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether vector data is extracted from tensor.
		/// </summary>
		// Token: 0x060125BC RID: 75196 RVA: 0x0019BB60 File Offset: 0x00199D60
		public virtual int GetExtractVectors()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetExtractVectors_12(base.GetCppThis());
		}

		// Token: 0x060125BD RID: 75197
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_GetNormalComponents_13(HandleRef pThis);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x060125BE RID: 75198 RVA: 0x0019BB80 File Offset: 0x00199D80
		public virtual int[] GetNormalComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalComponents_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060125BF RID: 75199
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_GetNormalComponents_14(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x060125C0 RID: 75200 RVA: 0x0019BBC8 File Offset: 0x00199DC8
		public virtual void GetNormalComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalComponents_14(base.GetCppThis(), data);
		}

		// Token: 0x060125C1 RID: 75201
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetNormalizeNormals_15(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal vector is converted to unit normal
		/// after extraction.
		/// </summary>
		// Token: 0x060125C2 RID: 75202 RVA: 0x0019BBD8 File Offset: 0x00199DD8
		public virtual int GetNormalizeNormals()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNormalizeNormals_15(base.GetCppThis());
		}

		// Token: 0x060125C3 RID: 75203
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractTensorComponents_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125C4 RID: 75204 RVA: 0x0019BBF8 File Offset: 0x00199DF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x060125C5 RID: 75205
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractTensorComponents_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125C6 RID: 75206 RVA: 0x0019BC18 File Offset: 0x00199E18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x060125C7 RID: 75207
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoords_18(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the texture coordinates to extract.
		/// </summary>
		// Token: 0x060125C8 RID: 75208 RVA: 0x0019BC34 File Offset: 0x00199E34
		public virtual int GetNumberOfTCoords()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoords_18(base.GetCppThis());
		}

		// Token: 0x060125C9 RID: 75209
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the texture coordinates to extract.
		/// </summary>
		// Token: 0x060125CA RID: 75210 RVA: 0x0019BC54 File Offset: 0x00199E54
		public virtual int GetNumberOfTCoordsMaxValue()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoordsMaxValue_19(base.GetCppThis());
		}

		// Token: 0x060125CB RID: 75211
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the dimension of the texture coordinates to extract.
		/// </summary>
		// Token: 0x060125CC RID: 75212 RVA: 0x0019BC74 File Offset: 0x00199E74
		public virtual int GetNumberOfTCoordsMinValue()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetNumberOfTCoordsMinValue_20(base.GetCppThis());
		}

		// Token: 0x060125CD RID: 75213
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetOutputPrecision_21(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. Note that any data that
		/// is simply passed through the filter to its output retains its input
		/// type, only newly created data added to the output is affected by this
		/// flag. By default the output type is the same as the input tensor type.
		/// </summary>
		// Token: 0x060125CE RID: 75214 RVA: 0x0019BC94 File Offset: 0x00199E94
		public virtual int GetOutputPrecision()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetOutputPrecision_21(base.GetCppThis());
		}

		// Token: 0x060125CF RID: 75215
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetPassTensorsToOutput_22(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tensor data is passed through to the output.
		/// </summary>
		// Token: 0x060125D0 RID: 75216 RVA: 0x0019BCB4 File Offset: 0x00199EB4
		public virtual int GetPassTensorsToOutput()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetPassTensorsToOutput_22(base.GetCppThis());
		}

		// Token: 0x060125D1 RID: 75217
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_GetScalarComponents_23(HandleRef pThis);

		/// <summary>
		/// Specify the (row,column) tensor component to extract as a scalar.
		/// </summary>
		// Token: 0x060125D2 RID: 75218 RVA: 0x0019BCD4 File Offset: 0x00199ED4
		public virtual int[] GetScalarComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarComponents_23(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060125D3 RID: 75219
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_GetScalarComponents_24(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the (row,column) tensor component to extract as a scalar.
		/// </summary>
		// Token: 0x060125D4 RID: 75220 RVA: 0x0019BD1C File Offset: 0x00199F1C
		public virtual void GetScalarComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarComponents_24(base.GetCppThis(), data);
		}

		// Token: 0x060125D5 RID: 75221
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_GetScalarMode_25(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125D6 RID: 75222 RVA: 0x0019BD2C File Offset: 0x00199F2C
		public virtual int GetScalarMode()
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_GetScalarMode_25(base.GetCppThis());
		}

		// Token: 0x060125D7 RID: 75223
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_GetTCoordComponents_26(HandleRef pThis);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector. Up to NumberOfTCoords
		/// components are extracted.
		/// </summary>
		// Token: 0x060125D8 RID: 75224 RVA: 0x0019BD4C File Offset: 0x00199F4C
		public virtual int[] GetTCoordComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetTCoordComponents_26(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060125D9 RID: 75225
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_GetTCoordComponents_27(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector. Up to NumberOfTCoords
		/// components are extracted.
		/// </summary>
		// Token: 0x060125DA RID: 75226 RVA: 0x0019BD94 File Offset: 0x00199F94
		public virtual void GetTCoordComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetTCoordComponents_27(base.GetCppThis(), data);
		}

		// Token: 0x060125DB RID: 75227
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_GetVectorComponents_28(HandleRef pThis);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x060125DC RID: 75228 RVA: 0x0019BDA4 File Offset: 0x00199FA4
		public virtual int[] GetVectorComponents()
		{
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_GetVectorComponents_28(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060125DD RID: 75229
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_GetVectorComponents_29(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x060125DE RID: 75230 RVA: 0x0019BDEC File Offset: 0x00199FEC
		public virtual void GetVectorComponents(IntPtr data)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_GetVectorComponents_29(base.GetCppThis(), data);
		}

		// Token: 0x060125DF RID: 75231
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_IsA_30(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125E0 RID: 75232 RVA: 0x0019BDFC File Offset: 0x00199FFC
		public override int IsA(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_IsA_30(base.GetCppThis(), type);
		}

		// Token: 0x060125E1 RID: 75233
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractTensorComponents_IsTypeOf_31([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125E2 RID: 75234 RVA: 0x0019BE1C File Offset: 0x0019A01C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractTensorComponents.vtkExtractTensorComponents_IsTypeOf_31(type);
		}

		// Token: 0x060125E3 RID: 75235
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125E4 RID: 75236 RVA: 0x0019BE38 File Offset: 0x0019A038
		public new vtkExtractTensorComponents NewInstance()
		{
			vtkExtractTensorComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_NewInstance_33(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060125E5 RID: 75237
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_NormalizeNormalsOff_34(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal vector is converted to unit normal
		/// after extraction.
		/// </summary>
		// Token: 0x060125E6 RID: 75238 RVA: 0x0019BE92 File Offset: 0x0019A092
		public virtual void NormalizeNormalsOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_NormalizeNormalsOff_34(base.GetCppThis());
		}

		// Token: 0x060125E7 RID: 75239
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_NormalizeNormalsOn_35(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether normal vector is converted to unit normal
		/// after extraction.
		/// </summary>
		// Token: 0x060125E8 RID: 75240 RVA: 0x0019BEA1 File Offset: 0x0019A0A1
		public virtual void NormalizeNormalsOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_NormalizeNormalsOn_35(base.GetCppThis());
		}

		// Token: 0x060125E9 RID: 75241
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOff_36(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tensor data is passed through to the output.
		/// </summary>
		// Token: 0x060125EA RID: 75242 RVA: 0x0019BEB0 File Offset: 0x0019A0B0
		public virtual void PassTensorsToOutputOff()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_PassTensorsToOutputOff_36(base.GetCppThis());
		}

		// Token: 0x060125EB RID: 75243
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_PassTensorsToOutputOn_37(HandleRef pThis);

		/// <summary>
		/// Boolean controls whether tensor data is passed through to the output.
		/// </summary>
		// Token: 0x060125EC RID: 75244 RVA: 0x0019BEBF File Offset: 0x0019A0BF
		public virtual void PassTensorsToOutputOn()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_PassTensorsToOutputOn_37(base.GetCppThis());
		}

		// Token: 0x060125ED RID: 75245
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractTensorComponents_SafeDownCast_38(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for obtaining type information, and printing.
		/// </summary>
		// Token: 0x060125EE RID: 75246 RVA: 0x0019BED0 File Offset: 0x0019A0D0
		public new static vtkExtractTensorComponents SafeDownCast(vtkObjectBase o)
		{
			vtkExtractTensorComponents vtkExtractTensorComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractTensorComponents.vtkExtractTensorComponents_SafeDownCast_38((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractTensorComponents = (vtkExtractTensorComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractTensorComponents.Register(null);
				}
			}
			return vtkExtractTensorComponents;
		}

		// Token: 0x060125EF RID: 75247
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ScalarIsComponent_39(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125F0 RID: 75248 RVA: 0x0019BF4F File Offset: 0x0019A14F
		public void ScalarIsComponent()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsComponent_39(base.GetCppThis());
		}

		// Token: 0x060125F1 RID: 75249
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ScalarIsDeterminant_40(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125F2 RID: 75250 RVA: 0x0019BF5E File Offset: 0x0019A15E
		public void ScalarIsDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsDeterminant_40(base.GetCppThis());
		}

		// Token: 0x060125F3 RID: 75251
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ScalarIsEffectiveStress_41(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125F4 RID: 75252 RVA: 0x0019BF6D File Offset: 0x0019A16D
		public void ScalarIsEffectiveStress()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsEffectiveStress_41(base.GetCppThis());
		}

		// Token: 0x060125F5 RID: 75253
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ScalarIsNonNegativeDeterminant_42(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125F6 RID: 75254 RVA: 0x0019BF7C File Offset: 0x0019A17C
		public void ScalarIsNonNegativeDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsNonNegativeDeterminant_42(base.GetCppThis());
		}

		// Token: 0x060125F7 RID: 75255
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_ScalarIsTrace_43(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x060125F8 RID: 75256 RVA: 0x0019BF8B File Offset: 0x0019A18B
		public void ScalarIsTrace()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_ScalarIsTrace_43(base.GetCppThis());
		}

		// Token: 0x060125F9 RID: 75257
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetExtractNormals_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether normal data is extracted from tensor.
		/// </summary>
		// Token: 0x060125FA RID: 75258 RVA: 0x0019BF9A File Offset: 0x0019A19A
		public virtual void SetExtractNormals(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractNormals_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060125FB RID: 75259
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetExtractScalars_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether scalar data is extracted from the tensors.
		/// </summary>
		// Token: 0x060125FC RID: 75260 RVA: 0x0019BFAA File Offset: 0x0019A1AA
		public virtual void SetExtractScalars(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractScalars_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060125FD RID: 75261
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetExtractTCoords_46(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether texture coordinates are extracted from tensor.
		/// </summary>
		// Token: 0x060125FE RID: 75262 RVA: 0x0019BFBA File Offset: 0x0019A1BA
		public virtual void SetExtractTCoords(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractTCoords_46(base.GetCppThis(), _arg);
		}

		// Token: 0x060125FF RID: 75263
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetExtractVectors_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether vector data is extracted from tensor.
		/// </summary>
		// Token: 0x06012600 RID: 75264 RVA: 0x0019BFCA File Offset: 0x0019A1CA
		public virtual void SetExtractVectors(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetExtractVectors_47(base.GetCppThis(), _arg);
		}

		// Token: 0x06012601 RID: 75265
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetNormalComponents_48(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x06012602 RID: 75266 RVA: 0x0019BFDA File Offset: 0x0019A1DA
		public virtual void SetNormalComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalComponents_48(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06012603 RID: 75267
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetNormalComponents_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x06012604 RID: 75268 RVA: 0x0019BFF2 File Offset: 0x0019A1F2
		public virtual void SetNormalComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalComponents_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06012605 RID: 75269
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetNormalizeNormals_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether normal vector is converted to unit normal
		/// after extraction.
		/// </summary>
		// Token: 0x06012606 RID: 75270 RVA: 0x0019C002 File Offset: 0x0019A202
		public virtual void SetNormalizeNormals(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNormalizeNormals_50(base.GetCppThis(), _arg);
		}

		// Token: 0x06012607 RID: 75271
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetNumberOfTCoords_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the dimension of the texture coordinates to extract.
		/// </summary>
		// Token: 0x06012608 RID: 75272 RVA: 0x0019C012 File Offset: 0x0019A212
		public virtual void SetNumberOfTCoords(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetNumberOfTCoords_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06012609 RID: 75273
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetOutputPrecision_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the
		/// documentation for the vtkAlgorithm::DesiredOutputPrecision enum for an
		/// explanation of the available precision settings. Note that any data that
		/// is simply passed through the filter to its output retains its input
		/// type, only newly created data added to the output is affected by this
		/// flag. By default the output type is the same as the input tensor type.
		/// </summary>
		// Token: 0x0601260A RID: 75274 RVA: 0x0019C022 File Offset: 0x0019A222
		public virtual void SetOutputPrecision(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetOutputPrecision_52(base.GetCppThis(), _arg);
		}

		// Token: 0x0601260B RID: 75275
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetPassTensorsToOutput_53(HandleRef pThis, int _arg);

		/// <summary>
		/// Boolean controls whether tensor data is passed through to the output.
		/// </summary>
		// Token: 0x0601260C RID: 75276 RVA: 0x0019C032 File Offset: 0x0019A232
		public virtual void SetPassTensorsToOutput(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetPassTensorsToOutput_53(base.GetCppThis(), _arg);
		}

		// Token: 0x0601260D RID: 75277
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarComponents_54(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Specify the (row,column) tensor component to extract as a scalar.
		/// </summary>
		// Token: 0x0601260E RID: 75278 RVA: 0x0019C042 File Offset: 0x0019A242
		public virtual void SetScalarComponents(int _arg1, int _arg2)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarComponents_54(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601260F RID: 75279
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarComponents_55(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the (row,column) tensor component to extract as a scalar.
		/// </summary>
		// Token: 0x06012610 RID: 75280 RVA: 0x0019C053 File Offset: 0x0019A253
		public void SetScalarComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarComponents_55(base.GetCppThis(), _arg);
		}

		// Token: 0x06012611 RID: 75281
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarMode_56(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x06012612 RID: 75282 RVA: 0x0019C063 File Offset: 0x0019A263
		public virtual void SetScalarMode(int _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarMode_56(base.GetCppThis(), _arg);
		}

		// Token: 0x06012613 RID: 75283
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToComponent_57(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x06012614 RID: 75284 RVA: 0x0019C073 File Offset: 0x0019A273
		public void SetScalarModeToComponent()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToComponent_57(base.GetCppThis());
		}

		// Token: 0x06012615 RID: 75285
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToDeterminant_58(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x06012616 RID: 75286 RVA: 0x0019C082 File Offset: 0x0019A282
		public void SetScalarModeToDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToDeterminant_58(base.GetCppThis());
		}

		// Token: 0x06012617 RID: 75287
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToEffectiveStress_59(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x06012618 RID: 75288 RVA: 0x0019C091 File Offset: 0x0019A291
		public void SetScalarModeToEffectiveStress()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToEffectiveStress_59(base.GetCppThis());
		}

		// Token: 0x06012619 RID: 75289
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToNonNegativeDeterminant_60(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x0601261A RID: 75290 RVA: 0x0019C0A0 File Offset: 0x0019A2A0
		public void SetScalarModeToNonNegativeDeterminant()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToNonNegativeDeterminant_60(base.GetCppThis());
		}

		// Token: 0x0601261B RID: 75291
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetScalarModeToTrace_61(HandleRef pThis);

		/// <summary>
		/// Specify how to extract the scalar. You can extract it as one of the
		/// components of the tensor, as effective stress, as the determinant of the
		/// tensor, a non-negative determinant, or the trace of the tensor
		/// matrix. If you extract a component make sure that you set the
		/// ScalarComponents ivar.
		/// </summary>
		// Token: 0x0601261C RID: 75292 RVA: 0x0019C0AF File Offset: 0x0019A2AF
		public void SetScalarModeToTrace()
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetScalarModeToTrace_61(base.GetCppThis());
		}

		// Token: 0x0601261D RID: 75293
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetTCoordComponents_62(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector. Up to NumberOfTCoords
		/// components are extracted.
		/// </summary>
		// Token: 0x0601261E RID: 75294 RVA: 0x0019C0BE File Offset: 0x0019A2BE
		public virtual void SetTCoordComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetTCoordComponents_62(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601261F RID: 75295
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetTCoordComponents_63(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector. Up to NumberOfTCoords
		/// components are extracted.
		/// </summary>
		// Token: 0x06012620 RID: 75296 RVA: 0x0019C0D6 File Offset: 0x0019A2D6
		public virtual void SetTCoordComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetTCoordComponents_63(base.GetCppThis(), _arg);
		}

		// Token: 0x06012621 RID: 75297
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetVectorComponents_64(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x06012622 RID: 75298 RVA: 0x0019C0E6 File Offset: 0x0019A2E6
		public virtual void SetVectorComponents(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetVectorComponents_64(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06012623 RID: 75299
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractTensorComponents_SetVectorComponents_65(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the ((row,column)0,(row,column)1,(row,column)2) tensor
		/// components to extract as a vector.
		/// </summary>
		// Token: 0x06012624 RID: 75300 RVA: 0x0019C0FE File Offset: 0x0019A2FE
		public virtual void SetVectorComponents(IntPtr _arg)
		{
			vtkExtractTensorComponents.vtkExtractTensorComponents_SetVectorComponents_65(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001520 RID: 5408
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTensorComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001521 RID: 5409
		public new static readonly string MRClassNameKey = "class vtkExtractTensorComponents";
	}
}
