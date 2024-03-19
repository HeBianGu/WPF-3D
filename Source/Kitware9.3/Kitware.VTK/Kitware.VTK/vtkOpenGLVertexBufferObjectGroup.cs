using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLVertexBufferObjectGroup
	/// </summary>
	/// <remarks>
	///    manage vertex buffer objects shared within a mapper
	///
	/// This class holds onto the VBOs that a mapper is using.
	/// The basic operation is that during the render process
	/// the mapper may cache a number of dataArrays as VBOs
	/// associated with attributes. This class keep track of
	/// freeing VBOs no longer used by the mapper and uploading
	/// new data as needed.
	///
	/// When using CacheCataArray the same array can be set
	/// each time and this class will not rebuild or upload
	/// unless needed.
	///
	/// When using the AppendDataArray API no caching is done
	/// and the VBOs will be rebuilt and uploaded each time.
	/// So when appending th emapper need to handle checking
	/// if the VBO should be updated.
	///
	/// Use case:
	///   make this an ivar of your mapper
	///   vbg-&gt;CacheDataArray("vertexMC", vtkDataArray);
	///   vbg-&gt;BuildAllVBOs();
	///   if (vbg-&gt;GetMTime() &gt; your VAO update time)
	///   {
	///     vbg-&gt;AddAllAttributesToVAO(...);
	///   }
	///
	/// Appended Use case:
	///   make this an ivar of your mapper
	///   if (you need to update your VBOs)
	///   {
	///     vbg-&gt;ClearAllVBOs();
	///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray1);
	///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray2);
	///     vbg-&gt;AppendDataArray("vertexMC", vtkDataArray3);
	///     vbg-&gt;BuildAllVBOs();
	///     vbg-&gt;AddAllAttributesToVAO(...);
	///   }
	///
	/// use VAO
	///
	/// </remarks>
	// Token: 0x020005D9 RID: 1497
	public class vtkOpenGLVertexBufferObjectGroup : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010593 RID: 66963 RVA: 0x0016C617 File Offset: 0x0016A817
		static vtkOpenGLVertexBufferObjectGroup()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLVertexBufferObjectGroup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLVertexBufferObjectGroup"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010594 RID: 66964 RVA: 0x0016C63F File Offset: 0x0016A83F
		public vtkOpenGLVertexBufferObjectGroup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010595 RID: 66965
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010596 RID: 66966 RVA: 0x0016C650 File Offset: 0x0016A850
		public new static vtkOpenGLVertexBufferObjectGroup New()
		{
			vtkOpenGLVertexBufferObjectGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010597 RID: 66967 RVA: 0x0016C6A4 File Offset: 0x0016A8A4
		public vtkOpenGLVertexBufferObjectGroup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010598 RID: 66968 RVA: 0x0016C6E8 File Offset: 0x0016A8E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010599 RID: 66969
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_AppendDataArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, HandleRef da, int destType);

		/// <summary>
		/// Append a data array for an attribute in the VBO Group
		/// registers the data array until build is called
		/// </summary>
		// Token: 0x0601059A RID: 66970 RVA: 0x0016C6F4 File Offset: 0x0016A8F4
		public void AppendDataArray(string attribute, vtkDataArray da, int destType)
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_AppendDataArray_01(base.GetCppThis(), attribute, (da == null) ? default(HandleRef) : da.GetCppThis(), destType);
		}

		// Token: 0x0601059B RID: 66971
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLVertexBufferObjectGroup_ArrayExists_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, HandleRef da, ref long offset, ref long totalOffset);

		/// <summary>
		/// Check if the array already exists.
		/// offset is the index of the first vertex of the array if it exists.
		/// totalOffset is the total number of vertices in the appended arrays.
		/// Note that if the array does not exist, offset is equal to totalOffset.
		/// </summary>
		// Token: 0x0601059C RID: 66972 RVA: 0x0016C728 File Offset: 0x0016A928
		public bool ArrayExists(string attribute, vtkDataArray da, ref long offset, ref long totalOffset)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_ArrayExists_02(base.GetCppThis(), attribute, (da == null) ? default(HandleRef) : da.GetCppThis(), ref offset, ref totalOffset) != 0;
		}

		// Token: 0x0601059D RID: 66973
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_BuildAllVBOs_03(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// using the data arrays in this group
		/// build all the VBOs, once this has been called the
		/// reference to the data arrays will be freed.
		/// </summary>
		// Token: 0x0601059E RID: 66974 RVA: 0x0016C768 File Offset: 0x0016A968
		public void BuildAllVBOs(vtkViewport arg0)
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_BuildAllVBOs_03(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601059F RID: 66975
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_CacheDataArray_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute, HandleRef da, HandleRef vp, int destType);

		/// <summary>
		/// Set the data array for an attribute in the VBO Group
		/// registers the data array until build is called
		/// once this is called a valid VBO will exist
		/// </summary>
		// Token: 0x060105A0 RID: 66976 RVA: 0x0016C798 File Offset: 0x0016A998
		public void CacheDataArray(string attribute, vtkDataArray da, vtkViewport vp, int destType)
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_CacheDataArray_04(base.GetCppThis(), attribute, (da == null) ? default(HandleRef) : da.GetCppThis(), (vp == null) ? default(HandleRef) : vp.GetCppThis(), destType);
		}

		// Token: 0x060105A1 RID: 66977
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_ClearAllDataArrays_05(HandleRef pThis);

		/// <summary>
		/// Clear all the data arrays. Typically an internal method.
		/// Automatically called at the end of BuildAllVBOs to prepare
		/// for the next set of attributes.
		/// </summary>
		// Token: 0x060105A2 RID: 66978 RVA: 0x0016C7DF File Offset: 0x0016A9DF
		public void ClearAllDataArrays()
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_ClearAllDataArrays_05(base.GetCppThis());
		}

		// Token: 0x060105A3 RID: 66979
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_ClearAllVBOs_06(HandleRef pThis);

		/// <summary>
		/// Force all the VBOs to be freed from this group.
		/// Call this prior to starting appending operations.
		/// Not needed for single array caching.
		/// </summary>
		// Token: 0x060105A4 RID: 66980 RVA: 0x0016C7EE File Offset: 0x0016A9EE
		public void ClearAllVBOs()
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_ClearAllVBOs_06(base.GetCppThis());
		}

		// Token: 0x060105A5 RID: 66981
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkOpenGLVertexBufferObjectGroup_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Get the mtime of this groups VBOs
		/// </summary>
		// Token: 0x060105A6 RID: 66982 RVA: 0x0016C800 File Offset: 0x0016AA00
		public override ulong GetMTime()
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x060105A7 RID: 66983
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLVertexBufferObjectGroup_GetNumberOfComponents_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Returns the number of components for this attribute
		/// zero if the attribute does not exist
		/// </summary>
		// Token: 0x060105A8 RID: 66984 RVA: 0x0016C820 File Offset: 0x0016AA20
		public int GetNumberOfComponents(string attribute)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_GetNumberOfComponents_08(base.GetCppThis(), attribute);
		}

		// Token: 0x060105A9 RID: 66985
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBase_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105AA RID: 66986 RVA: 0x0016C840 File Offset: 0x0016AA40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBase_09(base.GetCppThis(), type);
		}

		// Token: 0x060105AB RID: 66987
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBaseType_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105AC RID: 66988 RVA: 0x0016C860 File Offset: 0x0016AA60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_GetNumberOfGenerationsFromBaseType_10(type);
		}

		// Token: 0x060105AD RID: 66989
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLVertexBufferObjectGroup_GetNumberOfTuples_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// Returns the number of tuples for this attribute
		/// zero if the attribute does not exist
		/// </summary>
		// Token: 0x060105AE RID: 66990 RVA: 0x0016C87C File Offset: 0x0016AA7C
		public int GetNumberOfTuples(string attribute)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_GetNumberOfTuples_11(base.GetCppThis(), attribute);
		}

		// Token: 0x060105AF RID: 66991
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLVertexBufferObjectGroup_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105B0 RID: 66992 RVA: 0x0016C89C File Offset: 0x0016AA9C
		public override int IsA(string type)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x060105B1 RID: 66993
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLVertexBufferObjectGroup_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105B2 RID: 66994 RVA: 0x0016C8BC File Offset: 0x0016AABC
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_IsTypeOf_13(type);
		}

		// Token: 0x060105B3 RID: 66995
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105B4 RID: 66996 RVA: 0x0016C8D8 File Offset: 0x0016AAD8
		public new vtkOpenGLVertexBufferObjectGroup NewInstance()
		{
			vtkOpenGLVertexBufferObjectGroup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060105B5 RID: 66997
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_ReleaseGraphicsResources_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this mapper.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x060105B6 RID: 66998 RVA: 0x0016C934 File Offset: 0x0016AB34
		public void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_ReleaseGraphicsResources_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060105B7 RID: 66999
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLVertexBufferObjectGroup_RemoveAttribute_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string attribute);

		/// <summary>
		/// used to remove a no longer needed attribute
		/// Calling CacheDataArray with a nullptr
		/// attribute will also work.
		/// </summary>
		// Token: 0x060105B8 RID: 67000 RVA: 0x0016C963 File Offset: 0x0016AB63
		public void RemoveAttribute(string attribute)
		{
			vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_RemoveAttribute_17(base.GetCppThis(), attribute);
		}

		// Token: 0x060105B9 RID: 67001
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLVertexBufferObjectGroup_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060105BA RID: 67002 RVA: 0x0016C974 File Offset: 0x0016AB74
		public new static vtkOpenGLVertexBufferObjectGroup SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLVertexBufferObjectGroup vtkOpenGLVertexBufferObjectGroup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLVertexBufferObjectGroup.vtkOpenGLVertexBufferObjectGroup_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLVertexBufferObjectGroup = (vtkOpenGLVertexBufferObjectGroup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLVertexBufferObjectGroup.Register(null);
				}
			}
			return vtkOpenGLVertexBufferObjectGroup;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012FD RID: 4861
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLVertexBufferObjectGroup";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012FE RID: 4862
		public new static readonly string MRClassNameKey = "class vtkOpenGLVertexBufferObjectGroup";
	}
}
