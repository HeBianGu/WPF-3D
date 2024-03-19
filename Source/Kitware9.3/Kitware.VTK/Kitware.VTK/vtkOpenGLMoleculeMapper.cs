using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLMoleculeMapper
	/// </summary>
	/// <remarks>
	///    An accelerated class for rendering molecules
	///
	/// A vtkMoleculeMapper that uses imposters to do the rendering. It uses
	/// vtkOpenGLSphereMapper and vtkOpenGLStickMapper to do the rendering.
	/// </remarks>
	// Token: 0x0200057A RID: 1402
	public class vtkOpenGLMoleculeMapper : vtkMoleculeMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F86C RID: 63596 RVA: 0x0015924B File Offset: 0x0015744B
		static vtkOpenGLMoleculeMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLMoleculeMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLMoleculeMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F86D RID: 63597 RVA: 0x00159273 File Offset: 0x00157473
		public vtkOpenGLMoleculeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F86E RID: 63598
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLMoleculeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F86F RID: 63599 RVA: 0x00159284 File Offset: 0x00157484
		public new static vtkOpenGLMoleculeMapper New()
		{
			vtkOpenGLMoleculeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F870 RID: 63600 RVA: 0x001592D8 File Offset: 0x001574D8
		public vtkOpenGLMoleculeMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F871 RID: 63601 RVA: 0x0015931C File Offset: 0x0015751C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F872 RID: 63602
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLMoleculeMapper_GetFastAtomMapper_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// provide access to the underlying mappers
		/// </summary>
		// Token: 0x0600F873 RID: 63603 RVA: 0x00159328 File Offset: 0x00157528
		public vtkOpenGLSphereMapper GetFastAtomMapper()
		{
			vtkOpenGLSphereMapper vtkOpenGLSphereMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_GetFastAtomMapper_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLSphereMapper = (vtkOpenGLSphereMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLSphereMapper.Register(null);
				}
			}
			return vtkOpenGLSphereMapper;
		}

		// Token: 0x0600F874 RID: 63604
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLMoleculeMapper_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F875 RID: 63605 RVA: 0x00159398 File Offset: 0x00157598
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600F876 RID: 63606
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLMoleculeMapper_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F877 RID: 63607 RVA: 0x001593B8 File Offset: 0x001575B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600F878 RID: 63608
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLMoleculeMapper_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F879 RID: 63609 RVA: 0x001593D4 File Offset: 0x001575D4
		public override int IsA(string type)
		{
			return vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F87A RID: 63610
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLMoleculeMapper_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F87B RID: 63611 RVA: 0x001593F4 File Offset: 0x001575F4
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_IsTypeOf_05(type);
		}

		// Token: 0x0600F87C RID: 63612
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLMoleculeMapper_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F87D RID: 63613 RVA: 0x00159410 File Offset: 0x00157610
		public new vtkOpenGLMoleculeMapper NewInstance()
		{
			vtkOpenGLMoleculeMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F87E RID: 63614
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLMoleculeMapper_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F87F RID: 63615 RVA: 0x0015946C File Offset: 0x0015766C
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_ReleaseGraphicsResources_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600F880 RID: 63616
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLMoleculeMapper_Render_09(HandleRef pThis, HandleRef arg0, HandleRef arg1);

		/// <summary>
		/// Reimplemented from base class
		/// </summary>
		// Token: 0x0600F881 RID: 63617 RVA: 0x0015949C File Offset: 0x0015769C
		public override void Render(vtkRenderer arg0, vtkActor arg1)
		{
			vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_Render_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0600F882 RID: 63618
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLMoleculeMapper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F883 RID: 63619 RVA: 0x001594E0 File Offset: 0x001576E0
		public new static vtkOpenGLMoleculeMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLMoleculeMapper vtkOpenGLMoleculeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLMoleculeMapper = (vtkOpenGLMoleculeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLMoleculeMapper.Register(null);
				}
			}
			return vtkOpenGLMoleculeMapper;
		}

		// Token: 0x0600F884 RID: 63620
		[DllImport("Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLMoleculeMapper_SetMapScalars_11(HandleRef pThis, byte map);

		/// <summary>
		/// Helper method to set ScalarMode on both FastAtomMapper and FastBondMapper.
		/// true means VTK_COLOR_MODE_MAP_SCALARS, false VTK_COLOR_MODE_DIRECT_SCALARS.
		/// </summary>
		// Token: 0x0600F885 RID: 63621 RVA: 0x0015955F File Offset: 0x0015775F
		public override void SetMapScalars(bool map)
		{
			vtkOpenGLMoleculeMapper.vtkOpenGLMoleculeMapper_SetMapScalars_11(base.GetCppThis(), map ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400120D RID: 4621
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLMoleculeMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400120E RID: 4622
		public new static readonly string MRClassNameKey = "class vtkOpenGLMoleculeMapper";
	}
}
