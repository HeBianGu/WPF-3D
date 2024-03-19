using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVertexListIterator
	/// </summary>
	/// <remarks>
	///    Iterates all vertices in a graph.
	///
	///
	/// vtkVertexListIterator iterates through all vertices in a graph.
	/// Create an instance of this and call graph-&gt;GetVertices(it) to initialize
	/// this iterator. You may alternately call SetGraph() to initialize the
	/// iterator.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGraph
	/// </seealso>
	// Token: 0x02000AE1 RID: 2785
	public class vtkVertexListIterator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D5FE RID: 120318 RVA: 0x00297995 File Offset: 0x00295B95
		static vtkVertexListIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexListIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexListIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D5FF RID: 120319 RVA: 0x002979BD File Offset: 0x00295BBD
		public vtkVertexListIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D600 RID: 120320
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexListIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D601 RID: 120321 RVA: 0x002979CC File Offset: 0x00295BCC
		public new static vtkVertexListIterator New()
		{
			vtkVertexListIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D602 RID: 120322 RVA: 0x00297A20 File Offset: 0x00295C20
		public vtkVertexListIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVertexListIterator.vtkVertexListIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D603 RID: 120323 RVA: 0x00297A64 File Offset: 0x00295C64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D604 RID: 120324
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexListIterator_GetGraph_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the graph associated with this iterator.
		/// </summary>
		// Token: 0x0601D605 RID: 120325 RVA: 0x00297A70 File Offset: 0x00295C70
		public virtual vtkGraph GetGraph()
		{
			vtkGraph vtkGraph = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_GetGraph_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraph = (vtkGraph)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraph.Register(null);
				}
			}
			return vtkGraph;
		}

		// Token: 0x0601D606 RID: 120326
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexListIterator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D607 RID: 120327 RVA: 0x00297AE0 File Offset: 0x00295CE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601D608 RID: 120328
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexListIterator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D609 RID: 120329 RVA: 0x00297B00 File Offset: 0x00295D00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601D60A RID: 120330
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkVertexListIterator_HasNext_04(HandleRef pThis);

		/// <summary>
		/// Whether this iterator has more edges.
		/// </summary>
		// Token: 0x0601D60B RID: 120331 RVA: 0x00297B1C File Offset: 0x00295D1C
		public bool HasNext()
		{
			return vtkVertexListIterator.vtkVertexListIterator_HasNext_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601D60C RID: 120332
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexListIterator_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D60D RID: 120333 RVA: 0x00297B44 File Offset: 0x00295D44
		public override int IsA(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601D60E RID: 120334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexListIterator_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D60F RID: 120335 RVA: 0x00297B64 File Offset: 0x00295D64
		public new static int IsTypeOf(string type)
		{
			return vtkVertexListIterator.vtkVertexListIterator_IsTypeOf_06(type);
		}

		// Token: 0x0601D610 RID: 120336
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexListIterator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D611 RID: 120337 RVA: 0x00297B80 File Offset: 0x00295D80
		public new vtkVertexListIterator NewInstance()
		{
			vtkVertexListIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D612 RID: 120338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexListIterator_Next_09(HandleRef pThis);

		/// <summary>
		/// Returns the next edge in the graph.
		/// </summary>
		// Token: 0x0601D613 RID: 120339 RVA: 0x00297BDC File Offset: 0x00295DDC
		public long Next()
		{
			return vtkVertexListIterator.vtkVertexListIterator_Next_09(base.GetCppThis());
		}

		// Token: 0x0601D614 RID: 120340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexListIterator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D615 RID: 120341 RVA: 0x00297BFC File Offset: 0x00295DFC
		public new static vtkVertexListIterator SafeDownCast(vtkObjectBase o)
		{
			vtkVertexListIterator vtkVertexListIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexListIterator.vtkVertexListIterator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexListIterator = (vtkVertexListIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexListIterator.Register(null);
				}
			}
			return vtkVertexListIterator;
		}

		// Token: 0x0601D616 RID: 120342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertexListIterator_SetGraph_11(HandleRef pThis, HandleRef graph);

		/// <summary>
		/// Setup the iterator with a graph.
		/// </summary>
		// Token: 0x0601D617 RID: 120343 RVA: 0x00297C7C File Offset: 0x00295E7C
		public virtual void SetGraph(vtkGraph graph)
		{
			vtkVertexListIterator.vtkVertexListIterator_SetGraph_11(base.GetCppThis(), (graph == null) ? default(HandleRef) : graph.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EE9 RID: 7913
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexListIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EEA RID: 7914
		public new static readonly string MRClassNameKey = "class vtkVertexListIterator";
	}
}
