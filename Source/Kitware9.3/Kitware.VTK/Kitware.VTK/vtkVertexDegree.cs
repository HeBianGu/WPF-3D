using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVertexDegree
	/// </summary>
	/// <remarks>
	///    Adds an attribute array with the degree of each vertex
	///
	///
	/// Adds an attribute array with the degree of each vertex. By default the name
	/// of the array will be "VertexDegree", but that can be changed by calling
	/// SetOutputArrayName("foo");
	/// </remarks>
	// Token: 0x020006A0 RID: 1696
	public class vtkVertexDegree : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601223F RID: 74303 RVA: 0x00196813 File Offset: 0x00194A13
		static vtkVertexDegree()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVertexDegree.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVertexDegree"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012240 RID: 74304 RVA: 0x0019683B File Offset: 0x00194A3B
		public vtkVertexDegree(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012241 RID: 74305
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexDegree_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012242 RID: 74306 RVA: 0x0019684C File Offset: 0x00194A4C
		public new static vtkVertexDegree New()
		{
			vtkVertexDegree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012243 RID: 74307 RVA: 0x001968A0 File Offset: 0x00194AA0
		public vtkVertexDegree() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVertexDegree.vtkVertexDegree_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012244 RID: 74308 RVA: 0x001968E4 File Offset: 0x00194AE4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012245 RID: 74309
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexDegree_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012246 RID: 74310 RVA: 0x001968F0 File Offset: 0x00194AF0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012247 RID: 74311
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVertexDegree_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012248 RID: 74312 RVA: 0x00196910 File Offset: 0x00194B10
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012249 RID: 74313
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexDegree_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601224A RID: 74314 RVA: 0x0019692C File Offset: 0x00194B2C
		public override int IsA(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601224B RID: 74315
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVertexDegree_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601224C RID: 74316 RVA: 0x0019694C File Offset: 0x00194B4C
		public new static int IsTypeOf(string type)
		{
			return vtkVertexDegree.vtkVertexDegree_IsTypeOf_04(type);
		}

		// Token: 0x0601224D RID: 74317
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexDegree_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601224E RID: 74318 RVA: 0x00196968 File Offset: 0x00194B68
		public new vtkVertexDegree NewInstance()
		{
			vtkVertexDegree result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601224F RID: 74319
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVertexDegree_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012250 RID: 74320 RVA: 0x001969C4 File Offset: 0x00194BC4
		public new static vtkVertexDegree SafeDownCast(vtkObjectBase o)
		{
			vtkVertexDegree vtkVertexDegree = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVertexDegree.vtkVertexDegree_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVertexDegree = (vtkVertexDegree)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVertexDegree.Register(null);
				}
			}
			return vtkVertexDegree;
		}

		// Token: 0x06012251 RID: 74321
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVertexDegree_SetOutputArrayName_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the output array name. If no output array name is
		/// set then the name 'VertexDegree' is used.
		/// </summary>
		// Token: 0x06012252 RID: 74322 RVA: 0x00196A43 File Offset: 0x00194C43
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkVertexDegree.vtkVertexDegree_SetOutputArrayName_08(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014EE RID: 5358
		public new const string MRFullTypeName = "Kitware.VTK.vtkVertexDegree";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014EF RID: 5359
		public new static readonly string MRClassNameKey = "class vtkVertexDegree";
	}
}
