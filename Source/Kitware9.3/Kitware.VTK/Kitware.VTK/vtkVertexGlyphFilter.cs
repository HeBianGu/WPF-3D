using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVertexGlyphFilter
	/// </summary>
	/// <remarks>
	///    Make a vtkPolyData with a vertex on each point.
	///
	///
	///
	/// This filter throws away all of the cells in the input and replaces them with
	/// a vertex on each point.  The intended use of this filter is roughly
	/// equivalent to the vtkGlyph3D filter, except this filter is specifically for
	/// data that has many vertices, making the rendered result faster and less
	/// cluttered than the glyph filter. This filter may take a graph or point set
	/// as input.
	///
	/// </remarks>
	// Token: 0x020008F6 RID: 2294
	public class vtkVertexGlyphFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017B23 RID: 97059 RVA: 0x002139FB File Offset: 0x00211BFB
		static vtkVertexGlyphFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexGlyphFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexGlyphFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017B24 RID: 97060 RVA: 0x00213A23 File Offset: 0x00211C23
		public vtkVertexGlyphFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017B25 RID: 97061
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexGlyphFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B26 RID: 97062 RVA: 0x00213A34 File Offset: 0x00211C34
		public new static vtkVertexGlyphFilter New()
		{
			vtkVertexGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B27 RID: 97063 RVA: 0x00213A88 File Offset: 0x00211C88
		public vtkVertexGlyphFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVertexGlyphFilter.vtkVertexGlyphFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017B28 RID: 97064 RVA: 0x00213ACC File Offset: 0x00211CCC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017B29 RID: 97065
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexGlyphFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B2A RID: 97066 RVA: 0x00213AD8 File Offset: 0x00211CD8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017B2B RID: 97067
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexGlyphFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B2C RID: 97068 RVA: 0x00213AF8 File Offset: 0x00211CF8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017B2D RID: 97069
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexGlyphFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B2E RID: 97070 RVA: 0x00213B14 File Offset: 0x00211D14
		public override int IsA(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06017B2F RID: 97071
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexGlyphFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B30 RID: 97072 RVA: 0x00213B34 File Offset: 0x00211D34
		public new static int IsTypeOf(string type)
		{
			return vtkVertexGlyphFilter.vtkVertexGlyphFilter_IsTypeOf_04(type);
		}

		// Token: 0x06017B31 RID: 97073
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexGlyphFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B32 RID: 97074 RVA: 0x00213B50 File Offset: 0x00211D50
		public new vtkVertexGlyphFilter NewInstance()
		{
			vtkVertexGlyphFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B33 RID: 97075
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexGlyphFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B34 RID: 97076 RVA: 0x00213BAC File Offset: 0x00211DAC
		public new static vtkVertexGlyphFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVertexGlyphFilter vtkVertexGlyphFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexGlyphFilter.vtkVertexGlyphFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexGlyphFilter = (vtkVertexGlyphFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexGlyphFilter.Register(null);
				}
			}
			return vtkVertexGlyphFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6B RID: 6763
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexGlyphFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6C RID: 6764
		public new static readonly string MRClassNameKey = "class vtkVertexGlyphFilter";
	}
}
