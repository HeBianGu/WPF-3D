using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkChacoReader
	/// </summary>
	/// <remarks>
	///    Read a Chaco file and create a vtkUnstructuredGrid.
	///
	/// vtkChacoReader is an unstructured grid source object that reads Chaco
	/// files.  The reader DOES NOT respond to piece requests. Chaco
	/// is a graph partitioning package developed at Sandia National Laboratories
	/// in the early 1990s.  (http://www.cs.sandia.gov/~bahendr/chaco.html)
	///
	/// Note that the Chaco "edges" become VTK "cells", and the Chaco
	/// "vertices" become VTK "points".
	/// </remarks>
	// Token: 0x02000158 RID: 344
	public class vtkChacoReader : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060041B4 RID: 16820 RVA: 0x00060507 File Offset: 0x0005E707
		static vtkChacoReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkChacoReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkChacoReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060041B5 RID: 16821 RVA: 0x0006052F File Offset: 0x0005E72F
		public vtkChacoReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060041B6 RID: 16822
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041B7 RID: 16823 RVA: 0x00060540 File Offset: 0x0005E740
		public new static vtkChacoReader New()
		{
			vtkChacoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041B8 RID: 16824 RVA: 0x00060594 File Offset: 0x0005E794
		public vtkChacoReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkChacoReader.vtkChacoReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060041B9 RID: 16825 RVA: 0x000605D8 File Offset: 0x0005E7D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060041BA RID: 16826
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOff_01(HandleRef pThis);

		/// <summary>
		/// Each edge in the Chaco file connects two vertices.  The file may
		/// specify one or more weights for each edge.  (The weight for an
		/// edge from vertex A to vertex B equals the weight from B to A.)
		/// Indicate with the following parameter whether this reader should
		/// create a cell array for each weight for every edge.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041BB RID: 16827 RVA: 0x000605E3 File Offset: 0x0005E7E3
		public virtual void GenerateEdgeWeightArraysOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateEdgeWeightArraysOff_01(base.GetCppThis());
		}

		// Token: 0x060041BC RID: 16828
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateEdgeWeightArraysOn_02(HandleRef pThis);

		/// <summary>
		/// Each edge in the Chaco file connects two vertices.  The file may
		/// specify one or more weights for each edge.  (The weight for an
		/// edge from vertex A to vertex B equals the weight from B to A.)
		/// Indicate with the following parameter whether this reader should
		/// create a cell array for each weight for every edge.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041BD RID: 16829 RVA: 0x000605F2 File Offset: 0x0005E7F2
		public virtual void GenerateEdgeWeightArraysOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateEdgeWeightArraysOn_02(base.GetCppThis());
		}

		// Token: 0x060041BE RID: 16830
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOff_03(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a cell array containing
		/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
		/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041BF RID: 16831 RVA: 0x00060601 File Offset: 0x0005E801
		public virtual void GenerateGlobalElementIdArrayOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalElementIdArrayOff_03(base.GetCppThis());
		}

		// Token: 0x060041C0 RID: 16832
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateGlobalElementIdArrayOn_04(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a cell array containing
		/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
		/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041C1 RID: 16833 RVA: 0x00060610 File Offset: 0x0005E810
		public virtual void GenerateGlobalElementIdArrayOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalElementIdArrayOn_04(base.GetCppThis());
		}

		// Token: 0x060041C2 RID: 16834
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array of global IDs for
		/// the points in the output vtkUnstructuredGrid.  These points are the vertices
		/// that were in the Chaco file.  Global point IDs start at "1" for the first
		/// vertex in BaseName.coords and go up from there.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041C3 RID: 16835 RVA: 0x0006061F File Offset: 0x0005E81F
		public virtual void GenerateGlobalNodeIdArrayOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalNodeIdArrayOff_05(base.GetCppThis());
		}

		// Token: 0x060041C4 RID: 16836
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array of global IDs for
		/// the points in the output vtkUnstructuredGrid.  These points are the vertices
		/// that were in the Chaco file.  Global point IDs start at "1" for the first
		/// vertex in BaseName.coords and go up from there.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041C5 RID: 16837 RVA: 0x0006062E File Offset: 0x0005E82E
		public virtual void GenerateGlobalNodeIdArrayOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateGlobalNodeIdArrayOn_06(base.GetCppThis());
		}

		// Token: 0x060041C6 RID: 16838
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateVertexWeightArraysOff_07(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array for each
		/// vertex weight in the Chaco file.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041C7 RID: 16839 RVA: 0x0006063D File Offset: 0x0005E83D
		public virtual void GenerateVertexWeightArraysOff()
		{
			vtkChacoReader.vtkChacoReader_GenerateVertexWeightArraysOff_07(base.GetCppThis());
		}

		// Token: 0x060041C8 RID: 16840
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_GenerateVertexWeightArraysOn_08(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array for each
		/// vertex weight in the Chaco file.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041C9 RID: 16841 RVA: 0x0006064C File Offset: 0x0005E84C
		public virtual void GenerateVertexWeightArraysOn()
		{
			vtkChacoReader.vtkChacoReader_GenerateVertexWeightArraysOn_08(base.GetCppThis());
		}

		// Token: 0x060041CA RID: 16842
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_GetBaseName_09(HandleRef pThis);

		/// <summary>
		/// Specify the base name of the Chaco files.  The reader will try to
		/// open BaseName.coords and BaseName.graph.
		/// </summary>
		// Token: 0x060041CB RID: 16843 RVA: 0x0006065C File Offset: 0x0005E85C
		public virtual string GetBaseName()
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetBaseName_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060041CC RID: 16844
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetDimensionality_10(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by RequestInformation.
		/// </summary>
		// Token: 0x060041CD RID: 16845 RVA: 0x00060698 File Offset: 0x0005E898
		public virtual int GetDimensionality()
		{
			return vtkChacoReader.vtkChacoReader_GetDimensionality_10(base.GetCppThis());
		}

		// Token: 0x060041CE RID: 16846
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_GetEdgeWeightArrayName_11(HandleRef pThis, int weight);

		/// <summary>
		/// This method returns the name of the selected Edge weight cell
		/// array.  If you did not turn on GenerateEdgeWeightArrays, or
		/// if the weight you requested is invalid, it returns nullptr.
		/// Weights begin at one and go up to NumberOfEdgeWeights.
		/// This is a pointer to our copy of the name, so don't "delete" it.
		/// </summary>
		// Token: 0x060041CF RID: 16847 RVA: 0x000606B8 File Offset: 0x0005E8B8
		public string GetEdgeWeightArrayName(int weight)
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetEdgeWeightArrayName_11(base.GetCppThis(), weight));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060041D0 RID: 16848
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetGenerateEdgeWeightArrays_12(HandleRef pThis);

		/// <summary>
		/// Each edge in the Chaco file connects two vertices.  The file may
		/// specify one or more weights for each edge.  (The weight for an
		/// edge from vertex A to vertex B equals the weight from B to A.)
		/// Indicate with the following parameter whether this reader should
		/// create a cell array for each weight for every edge.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041D1 RID: 16849 RVA: 0x000606F4 File Offset: 0x0005E8F4
		public virtual int GetGenerateEdgeWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateEdgeWeightArrays_12(base.GetCppThis());
		}

		// Token: 0x060041D2 RID: 16850
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetGenerateGlobalElementIdArray_13(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a cell array containing
		/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
		/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041D3 RID: 16851 RVA: 0x00060714 File Offset: 0x0005E914
		public virtual int GetGenerateGlobalElementIdArray()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateGlobalElementIdArray_13(base.GetCppThis());
		}

		// Token: 0x060041D4 RID: 16852
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetGenerateGlobalNodeIdArray_14(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array of global IDs for
		/// the points in the output vtkUnstructuredGrid.  These points are the vertices
		/// that were in the Chaco file.  Global point IDs start at "1" for the first
		/// vertex in BaseName.coords and go up from there.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041D5 RID: 16853 RVA: 0x00060734 File Offset: 0x0005E934
		public virtual int GetGenerateGlobalNodeIdArray()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateGlobalNodeIdArray_14(base.GetCppThis());
		}

		// Token: 0x060041D6 RID: 16854
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetGenerateVertexWeightArrays_15(HandleRef pThis);

		/// <summary>
		/// Indicate whether this reader should create a point array for each
		/// vertex weight in the Chaco file.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041D7 RID: 16855 RVA: 0x00060754 File Offset: 0x0005E954
		public virtual int GetGenerateVertexWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetGenerateVertexWeightArrays_15(base.GetCppThis());
		}

		// Token: 0x060041D8 RID: 16856
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_GetGlobalElementIdArrayName_16();

		/// <summary>
		/// Indicate whether this reader should create a cell array containing
		/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
		/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041D9 RID: 16857 RVA: 0x00060774 File Offset: 0x0005E974
		public static string GetGlobalElementIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetGlobalElementIdArrayName_16());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060041DA RID: 16858
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_GetGlobalNodeIdArrayName_17();

		/// <summary>
		/// Indicate whether this reader should create a point array of global IDs for
		/// the points in the output vtkUnstructuredGrid.  These points are the vertices
		/// that were in the Chaco file.  Global point IDs start at "1" for the first
		/// vertex in BaseName.coords and go up from there.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041DB RID: 16859 RVA: 0x000607A8 File Offset: 0x0005E9A8
		public static string GetGlobalNodeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetGlobalNodeIdArrayName_17());
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060041DC RID: 16860
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetNumberOfCellWeightArrays_18(HandleRef pThis);

		/// <summary>
		/// After this filter executes, this method returns the number of
		/// cell arrays that were created to hold the edge weights.  It
		/// is equal to NumberOfEdgeWeights if GenerateEdgeWeightArrays was ON.
		/// </summary>
		// Token: 0x060041DD RID: 16861 RVA: 0x000607DC File Offset: 0x0005E9DC
		public virtual int GetNumberOfCellWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfCellWeightArrays_18(base.GetCppThis());
		}

		// Token: 0x060041DE RID: 16862
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetNumberOfEdgeWeights_19(HandleRef pThis);

		/// <summary>
		/// Returns the number of weights per edge in the Chaco file, whether or
		/// not GenerateEdgeWeightArrays is ON.
		/// </summary>
		// Token: 0x060041DF RID: 16863 RVA: 0x000607FC File Offset: 0x0005E9FC
		public virtual int GetNumberOfEdgeWeights()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfEdgeWeights_19(base.GetCppThis());
		}

		// Token: 0x060041E0 RID: 16864
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoReader_GetNumberOfEdges_20(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by RequestInformation.
		/// </summary>
		// Token: 0x060041E1 RID: 16865 RVA: 0x0006081C File Offset: 0x0005EA1C
		public virtual long GetNumberOfEdges()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfEdges_20(base.GetCppThis());
		}

		// Token: 0x060041E2 RID: 16866
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoReader_GetNumberOfGenerationsFromBase_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041E3 RID: 16867 RVA: 0x0006083C File Offset: 0x0005EA3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfGenerationsFromBase_21(base.GetCppThis(), type);
		}

		// Token: 0x060041E4 RID: 16868
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoReader_GetNumberOfGenerationsFromBaseType_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041E5 RID: 16869 RVA: 0x0006085C File Offset: 0x0005EA5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfGenerationsFromBaseType_22(type);
		}

		// Token: 0x060041E6 RID: 16870
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetNumberOfPointWeightArrays_23(HandleRef pThis);

		/// <summary>
		/// After this filter executes, this method returns the number of
		/// point arrays that were created to hold the vertex weights.  It
		/// is equal to NumberOfVertexWeights if GenerateVertexWeightArrays was ON.
		/// </summary>
		// Token: 0x060041E7 RID: 16871 RVA: 0x00060878 File Offset: 0x0005EA78
		public virtual int GetNumberOfPointWeightArrays()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfPointWeightArrays_23(base.GetCppThis());
		}

		// Token: 0x060041E8 RID: 16872
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_GetNumberOfVertexWeights_24(HandleRef pThis);

		/// <summary>
		/// Returns the number of weights per vertex in the Chaco file, whether or
		/// not GenerateVertexWeightArrays is ON.
		/// </summary>
		// Token: 0x060041E9 RID: 16873 RVA: 0x00060898 File Offset: 0x0005EA98
		public virtual int GetNumberOfVertexWeights()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfVertexWeights_24(base.GetCppThis());
		}

		// Token: 0x060041EA RID: 16874
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkChacoReader_GetNumberOfVertices_25(HandleRef pThis);

		/// <summary>
		/// Access to meta data generated by RequestInformation.
		/// </summary>
		// Token: 0x060041EB RID: 16875 RVA: 0x000608B8 File Offset: 0x0005EAB8
		public virtual long GetNumberOfVertices()
		{
			return vtkChacoReader.vtkChacoReader_GetNumberOfVertices_25(base.GetCppThis());
		}

		// Token: 0x060041EC RID: 16876
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_GetVertexWeightArrayName_26(HandleRef pThis, int weight);

		/// <summary>
		/// This method returns the name of the selected Vertex weight point
		/// array.  If you did not turn on GenerateVertexWeightArrays, or
		/// if the weight you requested is invalid, it returns nullptr.
		/// Weights begin at one and go up to NumberOfVertexWeights.
		/// This is a pointer to our copy of the name, so don't "delete" it.
		/// </summary>
		// Token: 0x060041ED RID: 16877 RVA: 0x000608D8 File Offset: 0x0005EAD8
		public string GetVertexWeightArrayName(int weight)
		{
			string s = Marshal.PtrToStringAnsi(vtkChacoReader.vtkChacoReader_GetVertexWeightArrayName_26(base.GetCppThis(), weight));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060041EE RID: 16878
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041EF RID: 16879 RVA: 0x00060914 File Offset: 0x0005EB14
		public override int IsA(string type)
		{
			return vtkChacoReader.vtkChacoReader_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x060041F0 RID: 16880
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkChacoReader_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041F1 RID: 16881 RVA: 0x00060934 File Offset: 0x0005EB34
		public new static int IsTypeOf(string type)
		{
			return vtkChacoReader.vtkChacoReader_IsTypeOf_28(type);
		}

		// Token: 0x060041F2 RID: 16882
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041F3 RID: 16883 RVA: 0x00060950 File Offset: 0x0005EB50
		public new vtkChacoReader NewInstance()
		{
			vtkChacoReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060041F4 RID: 16884
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkChacoReader_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060041F5 RID: 16885 RVA: 0x000609AC File Offset: 0x0005EBAC
		public new static vtkChacoReader SafeDownCast(vtkObjectBase o)
		{
			vtkChacoReader vtkChacoReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkChacoReader.vtkChacoReader_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkChacoReader = (vtkChacoReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkChacoReader.Register(null);
				}
			}
			return vtkChacoReader;
		}

		// Token: 0x060041F6 RID: 16886
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_SetBaseName_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify the base name of the Chaco files.  The reader will try to
		/// open BaseName.coords and BaseName.graph.
		/// </summary>
		// Token: 0x060041F7 RID: 16887 RVA: 0x00060A2B File Offset: 0x0005EC2B
		public virtual void SetBaseName(string _arg)
		{
			vtkChacoReader.vtkChacoReader_SetBaseName_32(base.GetCppThis(), _arg);
		}

		// Token: 0x060041F8 RID: 16888
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_SetGenerateEdgeWeightArrays_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Each edge in the Chaco file connects two vertices.  The file may
		/// specify one or more weights for each edge.  (The weight for an
		/// edge from vertex A to vertex B equals the weight from B to A.)
		/// Indicate with the following parameter whether this reader should
		/// create a cell array for each weight for every edge.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041F9 RID: 16889 RVA: 0x00060A3B File Offset: 0x0005EC3B
		public virtual void SetGenerateEdgeWeightArrays(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateEdgeWeightArrays_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060041FA RID: 16890
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_SetGenerateGlobalElementIdArray_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether this reader should create a cell array containing
		/// global IDs for the cells in the output vtkUnstructuredGrid.  These cells
		/// represent the edges that were in the Chaco file.  Each edge is a vtkLine.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041FB RID: 16891 RVA: 0x00060A4B File Offset: 0x0005EC4B
		public virtual void SetGenerateGlobalElementIdArray(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateGlobalElementIdArray_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060041FC RID: 16892
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_SetGenerateGlobalNodeIdArray_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether this reader should create a point array of global IDs for
		/// the points in the output vtkUnstructuredGrid.  These points are the vertices
		/// that were in the Chaco file.  Global point IDs start at "1" for the first
		/// vertex in BaseName.coords and go up from there.
		/// Default is ON.
		/// </summary>
		// Token: 0x060041FD RID: 16893 RVA: 0x00060A5B File Offset: 0x0005EC5B
		public virtual void SetGenerateGlobalNodeIdArray(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateGlobalNodeIdArray_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060041FE RID: 16894
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkChacoReader_SetGenerateVertexWeightArrays_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Indicate whether this reader should create a point array for each
		/// vertex weight in the Chaco file.
		/// Default is OFF.
		/// </summary>
		// Token: 0x060041FF RID: 16895 RVA: 0x00060A6B File Offset: 0x0005EC6B
		public virtual void SetGenerateVertexWeightArrays(int _arg)
		{
			vtkChacoReader.vtkChacoReader_SetGenerateVertexWeightArrays_36(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F5 RID: 1781
		public new const string MRFullTypeName = "Kitware.VTK.vtkChacoReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040006F6 RID: 1782
		public new static readonly string MRClassNameKey = "class vtkChacoReader";
	}
}
